using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WasteNoMoreUI.Models;

namespace WasteNoMoreUI
{
    public partial class FormBandingHarga : Form
    {
        private int currentId;
        bool sidebarExpand = false;

        public FormBandingHarga(int currentId)
        {
            InitializeComponent();
            this.currentId = currentId;

            sidebar.Width = 100;
            sidebarExpand = false;
        }

        private void FormBandingHarga_Load(object sender, EventArgs e)
        {
            LoadChecklistData();
        }

        public class ListItem
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name; // Untuk menampilkan nama di ChecklistBox
            }
        }

        private void LoadChecklistData()
        {
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();

                    // Load data aplikasi ke ChecklistBox (dengan filter is_deleted = false)
                    var cmdAplikasi = new NpgsqlCommand("SELECT id_aplikasi, nama_aplikasi FROM aplikasi WHERE is_deleted = false;", conn);
                    var adapterAplikasi = new NpgsqlDataAdapter(cmdAplikasi);
                    var dtAplikasi = new DataTable();
                    adapterAplikasi.Fill(dtAplikasi);

                    clbAplikasi.Items.Clear(); // Pastikan checklist box kosong sebelum menambah item
                    foreach (DataRow row in dtAplikasi.Rows)
                    {
                        clbAplikasi.Items.Add(new ListItem
                        {
                            Id = Convert.ToInt32(row["id_aplikasi"]),
                            Name = row["nama_aplikasi"].ToString()
                        });
                    }

                    // Load data kategori ke ChecklistBox (dengan filter is_deleted = false)
                    var cmdKategori = new NpgsqlCommand("SELECT id_kategori, nama_kategori FROM kategori WHERE is_deleted = false;", conn);
                    var adapterKategori = new NpgsqlDataAdapter(cmdKategori);
                    var dtKategori = new DataTable();
                    adapterKategori.Fill(dtKategori);

                    clbKategori.Items.Clear(); // Pastikan checklist box kosong sebelum menambah item
                    foreach (DataRow row in dtKategori.Rows)
                    {
                        clbKategori.Items.Add(new ListItem
                        {
                            Id = Convert.ToInt32(row["id_kategori"]),
                            Name = row["nama_kategori"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Data FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBandingkan_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil data aplikasi dan kategori yang dipilih
                var selectedAplikasiIds = clbAplikasi.CheckedItems.Cast<ListItem>().Select(item => item.Id).ToList();
                var selectedKategoriIds = clbKategori.CheckedItems.Cast<ListItem>().Select(item => item.Id).ToList();

                if (!selectedAplikasiIds.Any() || !selectedKategoriIds.Any())
                {
                    MessageBox.Show("Pilih minimal satu aplikasi dan satu kategori!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string aplikasiFilter = string.Join(",", selectedAplikasiIds);
                string kategoriFilter = string.Join(",", selectedKategoriIds);

                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();

                    // Ambil data harga berdasarkan aplikasi dan kategori
                    string query = $@"
                SELECT 
                    a.id_aplikasi,
                    k.id_kategori,
                    h.id_harga,
                    a.nama_aplikasi AS ""Nama Aplikasi"",
                    k.nama_kategori AS ""Nama Kategori"",
                    h.harga AS ""Harga per Kg""
                FROM harga h
                JOIN aplikasi a ON h.id_aplikasi = a.id_aplikasi
                JOIN kategori k ON h.id_kategori = k.id_kategori
                WHERE h.id_aplikasi IN ({aplikasiFilter}) 
                  AND h.id_kategori IN ({kategoriFilter})
                ORDER BY a.nama_aplikasi, k.nama_kategori;";

                    var dtResult = new DataTable();
                    new NpgsqlDataAdapter(query, conn).Fill(dtResult);

                    // Tambahkan kolom Berat (kg) dan Total Harga
                    dtResult.Columns.Add("Berat (kg)", typeof(double));
                    dtResult.Columns.Add("Total Harga", typeof(double));

                    // Validasi input berat (kg)
                    if (!double.TryParse(txtKuantitas.Text, out var berat) || berat <= 0)
                    {
                        MessageBox.Show("Masukkan berat (kg) yang valid!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Hitung Total Harga berdasarkan berat
                    foreach (DataRow row in dtResult.Rows)
                    {
                        var hargaPerKg = Convert.ToDouble(row["Harga per Kg"]);
                        row["Berat (kg)"] = berat;
                        row["Total Harga"] = hargaPerKg * berat;
                    }

                    // Tampilkan hasil ke DataGridView
                    dgvBandingHarga.DataSource = dtResult;

                    // Sembunyikan kolom ID
                    dgvBandingHarga.Columns["id_aplikasi"].Visible = false;
                    dgvBandingHarga.Columns["id_kategori"].Visible = false;
                    dgvBandingHarga.Columns["id_harga"].Visible = false;

                    // Format angka untuk kolom Harga per Kg dan Total Harga
                    dgvBandingHarga.Columns["Harga per Kg"].DefaultCellStyle.Format = "Rp #,0.00";
                    dgvBandingHarga.Columns["Total Harga"].DefaultCellStyle.Format = "Rp #,0.00";

                    // Simpan data perbandingan harga ke tabel perbandingan_harga
                    string insertBandingQuery = @"
                INSERT INTO perbandingan_harga (kuantitas_banding, total_harga)
                VALUES (@berat, @total_harga) RETURNING id_banding;";

                    decimal totalHarga = dtResult.AsEnumerable()
                        .Sum(row => Convert.ToDecimal(row["Total Harga"]));

                    int idBanding;
                    using (var insertBandingCmd = new NpgsqlCommand(insertBandingQuery, conn))
                    {
                        insertBandingCmd.Parameters.AddWithValue("@berat", berat);
                        insertBandingCmd.Parameters.AddWithValue("@total_harga", totalHarga);
                        idBanding = Convert.ToInt32(insertBandingCmd.ExecuteScalar());
                    }

                    // Simpan detail perbandingan harga
                    foreach (DataRow row in dtResult.Rows)
                    {
                        int idAplikasi = Convert.ToInt32(row["id_aplikasi"]);
                        int idKategori = Convert.ToInt32(row["id_kategori"]);
                        int idHarga = Convert.ToInt32(row["id_harga"]);

                        string insertDetailQuery = @"
                    INSERT INTO perbandingan_harga_detail (id_banding, id_aplikasi, id_kategori, id_harga)
                    VALUES (@id_banding, @id_aplikasi, @id_kategori, @id_harga);";

                        using (var insertDetailCmd = new NpgsqlCommand(insertDetailQuery, conn))
                        {
                            insertDetailCmd.Parameters.AddWithValue("@id_banding", idBanding);
                            insertDetailCmd.Parameters.AddWithValue("@id_aplikasi", idAplikasi);
                            insertDetailCmd.Parameters.AddWithValue("@id_kategori", idKategori);
                            insertDetailCmd.Parameters.AddWithValue("@id_harga", idHarga);
                            insertDetailCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Perbandingan harga berhasil.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Comparison FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvBandingHarga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void clbAplikasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelBanding_Click(object sender, EventArgs e)
        {
            FormDashboard dashboardForm = new FormDashboard(currentId);
            dashboardForm.Show();
            this.Hide();
        }


        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            
        }


        private void pbNavbar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnNavbarEntri_Click(object sender, EventArgs e)
        {
            //ketika button Entri Sampah di-klik maka form entri sampah dibuka
            FormEntriSampah inputSampahForm = new FormEntriSampah(currentId);
            inputSampahForm.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void btnNavbarTrack_Click(object sender, EventArgs e)
        {
            //ketika button Track Sampah di-klik maka form track sampah dibuka
            FormTrack formTrackSampah = new FormTrack(currentId);
            formTrackSampah.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void btnNavbarBandingHarga_Click(object sender, EventArgs e)
        {
            //ketika button Banding Harga di-klik maka form banidng harga dibuka
            FormBandingHarga formBandingHarga = new FormBandingHarga(currentId);
            formBandingHarga.Show();
            //form dashboard ditutup

            this.Hide();
        }

        private void btnNavbarAkun_Click(object sender, EventArgs e)
        {
            //ketika button data pengguna di-klik maka form data pengguna dibuka
            FormDataPengguna formDataPengguna = new FormDataPengguna(currentId);
            formDataPengguna.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void btnNavbarLogout_Click(object sender, EventArgs e)
        {
            //konfirmasi logout ke pengguna
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //jika pengguna memilih "Yes", maka proses logout dilanjutkan
            if (dialogResult == DialogResult.Yes)
            {
                //ketika button Logiut di-klik maka form login dibuka
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                //form dashboard ditutup
                this.Close();
            }
            //jika pengguna memilih "No", maka tetap di halaman dashboard
            else
            {

            }
        }

        private void btnNavbarDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard dashboardForm = new FormDashboard(currentId);
            dashboardForm.Show();
            this.Hide();
        }

        private void sidebarTransition_Tick_1(object sender, EventArgs e)
        {
            if (sidebarExpand) // Jika sidebar dalam keadaan terbuka
            {
                sidebar.Width -= 5; // Kurangi lebar sidebar secara bertahap
                if (sidebar.Width <= 100) // Jika lebar mencapai minimum
                {
                    sidebarExpand = false; // Tanda sidebar tertutup
                    sidebarTransition.Stop(); // Hentikan timer
                }
            }
            else // Jika sidebar dalam keadaan tertutup
            {
                sidebar.Width += 5; // Tambahkan lebar sidebar secara bertahap
                if (sidebar.Width >= 400) // Jika lebar mencapai maksimum
                {
                    sidebarExpand = true; // Tanda sidebar terbuka
                    sidebarTransition.Stop(); // Hentikan timer
                }
            }

            // Update ukuran panel lain jika perlu
            pnDashboard.Width = sidebar.Width;
            pnAkun.Width = sidebar.Width;
            pnBandingHarga.Width = sidebar.Width;
            pnEntri.Width = sidebar.Width;
            pnLogout.Width = sidebar.Width;
            pnPanduan.Width = sidebar.Width;
            pnTrack.Width = sidebar.Width;
        }
    }
}

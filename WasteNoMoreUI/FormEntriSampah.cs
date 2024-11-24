using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//import class
using WasteNoMoreUI.Models;

namespace WasteNoMoreUI
{
    public partial class FormEntriSampah : Form
    {
        private List<Kategori> kategoriList = new List<Kategori>();
        private int currentId;
        bool sidebarExpand = false;

        public FormEntriSampah(int currentId)
        {
            InitializeComponent();
            LoadKategori();
            this.currentId = currentId;

            sidebar.Width = 100;
            sidebarExpand = false;

        }

        private void LoadKategori()
        {
            //query untuk mengambil data kategori yang belum dihapus
            string query = "SELECT id_kategori, nama_kategori, deskripsi_kategori FROM kategori WHERE is_deleted = FALSE";

            //eksekusi query dan ambil data dari db
            DataTable dt = DatabaseManager.ExecuteQuery(query);

            //membersihkan data lama di list dan combo box
            kategoriList.Clear();
            cmbKategori.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                var kategori = new Kategori(
                    Convert.ToInt32(row["id_kategori"]),
                    row["nama_kategori"].ToString(),
                    row["deskripsi_kategori"].ToString()
                );

                //menambahkan kategori ke daftar dan combo box
                kategoriList.Add(kategori);
                cmbKategori.Items.Add(kategori.NamaKategori);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormDashboard dashboardForm = new FormDashboard(currentId);
            dashboardForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validasi input sudah terisi
            if (cmbKategori.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtBerat.Text))
            {
                MessageBox.Show("Pastikan semua data sudah terisi dengan benar!");
                return;
            }

            // Validasi tipe data yang dimasukkan dalam variable berat sampah
            if (!double.TryParse(txtBerat.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double beratSampah) || beratSampah <= 0)
            {
                MessageBox.Show("Berat sampah harus berupa angka desimal yang valid!");
                return;
            }

            // Membatasi dua angka di belakang koma
            beratSampah = Math.Round(beratSampah, 2);

            // Ambil id_kategori sesuai kategori dipilih
            var selectedKategori = kategoriList[cmbKategori.SelectedIndex];
            int idKategori = selectedKategori.IdKategori;

            // Ambil tanggal dari DateTimePicker
            DateTime waktuEntri = dtpEntri.Value;

            // Query untuk memasukkan data ke database
            string insertQuery = $"INSERT INTO sampah (id_pengguna, id_kategori, kuantitas, waktu_entri) " +
                                 $"VALUES ({currentId}, {idKategori}, {beratSampah.ToString(CultureInfo.InvariantCulture)}, '{waktuEntri:yyyy-MM-dd HH:mm:ss}')";

            try
            {
                // Eksekusi query untuk menyimpan data
                DatabaseManager.ExecuteQuery(insertQuery);
                MessageBox.Show("Sampah berhasil disimpan!");

                // Reset form
                cmbKategori.SelectedIndex = -1;
                txtBerat.Clear();
            }
            catch (Exception ex)
            {
                // Tampilkan pesan error jika terjadi kesalahan
                MessageBox.Show("Error: " + ex.Message, "Gagal Menyimpan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormEntriSampah_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
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
    }
}

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
    public partial class FormAplikasiAdmin : Form
    {
        private DataTable dt;
        private DataGridViewRow r;
        public FormAplikasiAdmin()
        {
            InitializeComponent();
        }

        private void LoadKategoriToComboBox()
        {
            try
            {
                // Bersihkan item di combobox terlebih dahulu
                cbKategori.Items.Clear();

                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT nama_kategori FROM kategori WHERE is_deleted = FALSE ORDER BY nama_kategori ASC;", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Tambahkan nama kategori ke ComboBox
                                cbKategori.Items.Add(reader["nama_kategori"].ToString());
                            }
                        }
                    }
                }

                // Beri placeholder jika tidak ada kategori
                if (cbKategori.Items.Count == 0)
                {
                    cbKategori.Items.Add("-- Tidak Ada Kategori --");
                }

                cbKategori.SelectedIndex = 0; // Pilih item pertama secara default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Kategori FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void pbInsertAplikasi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNamaAplikasi.Text) || cbKategori.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtHarga.Text))
                {
                    MessageBox.Show("Pastikan semua field telah diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();

                    // Mulai transaksi untuk memastikan konsistensi data
                    using (var trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // Dapatkan ID kategori berdasarkan nama yang dipilih di ComboBox
                            int idKategori;
                            using (var cmdKategori = new NpgsqlCommand("SELECT id_kategori FROM kategori WHERE nama_kategori = @nama_kategori AND is_deleted = FALSE", conn, trans))
                            {
                                cmdKategori.Parameters.AddWithValue("nama_kategori", cbKategori.SelectedItem.ToString());
                                var result = cmdKategori.ExecuteScalar();
                                if (result == null)
                                {
                                    throw new Exception("Kategori tidak ditemukan. Pastikan kategori valid.");
                                }
                                idKategori = Convert.ToInt32(result);
                            }

                            // Masukkan data ke tabel aplikasi
                            int idAplikasi;
                            using (var cmdAplikasi = new NpgsqlCommand(
                                "INSERT INTO aplikasi (nama_aplikasi, deskripsi_aplikasi) VALUES (@nama_aplikasi, @deskripsi_aplikasi) RETURNING id_aplikasi",
                                conn, trans))
                            {
                                cmdAplikasi.Parameters.AddWithValue("nama_aplikasi", txtNamaAplikasi.Text.Trim());
                                cmdAplikasi.Parameters.AddWithValue("deskripsi_aplikasi", string.IsNullOrWhiteSpace(txtDeskripsiAplikasi.Text) ? (object)DBNull.Value : txtDeskripsiAplikasi.Text.Trim());

                                idAplikasi = Convert.ToInt32(cmdAplikasi.ExecuteScalar());
                            }

                            // Masukkan data ke tabel harga
                            using (var cmdHarga = new NpgsqlCommand(
                                "INSERT INTO harga (id_kategori, id_aplikasi, harga) VALUES (@id_kategori, @id_aplikasi, @harga)",
                                conn, trans))
                            {
                                cmdHarga.Parameters.AddWithValue("id_kategori", idKategori);
                                cmdHarga.Parameters.AddWithValue("id_aplikasi", idAplikasi);
                                cmdHarga.Parameters.AddWithValue("harga", Convert.ToDecimal(txtHarga.Text.Trim()));

                                cmdHarga.ExecuteNonQuery();
                            }

                            // Commit transaksi
                            trans.Commit();

                            MessageBox.Show("Insert Berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Bersihkan input dan refresh data grid
                            txtNamaAplikasi.Clear();
                            txtDeskripsiAplikasi.Clear();
                            txtHarga.Clear();
                            cbKategori.SelectedIndex = 0;
                            LoadData();
                        }
                        catch
                        {
                            // Rollback jika ada error
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadData()
        {
            try
            {
                // Query untuk memanggil function di database
                string query = "SELECT * FROM get_aplikasi_data()";

                // Eksekusi query dan simpan hasil ke DataTable
                dt = DatabaseManager.ExecuteQuery(query);

                // Tampilkan data di DataGridView
                dgvAplikasi.DataSource = dt;
                dgvAplikasi.Columns["id_aplikasi"].HeaderText = "ID";
                dgvAplikasi.Columns["nama_aplikasi"].HeaderText = "Nama Aplikasi";
                dgvAplikasi.Columns["deskripsi_aplikasi"].HeaderText = "Deskripsi";
                dgvAplikasi.Columns["kategori"].HeaderText = "Kategori";
                dgvAplikasi.Columns["harga"].HeaderText = "Harga";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void FormAplikasiAdmin_Load(object sender, EventArgs e)
        {
            // Muat data ke DataGridView
            LoadData();

            // Muat data kategori ke ComboBox
            LoadKategoriToComboBox();
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ambil nama kategori yang dipilih dari ComboBox
            string selectedKategori = cbKategori.SelectedItem.ToString();
        }

        private void pbUpdateAplikasi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAplikasi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih aplikasi yang ingin diperbarui!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvAplikasi.SelectedRows[0];
                int idAplikasi = Convert.ToInt32(selectedRow.Cells["id_aplikasi"].Value);

                if (string.IsNullOrWhiteSpace(txtNamaAplikasi.Text) || cbKategori.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtHarga.Text))
                {
                    MessageBox.Show("Pastikan semua field telah diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();

                    // Mulai transaksi untuk memastikan konsistensi data
                    using (var trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // Dapatkan ID kategori berdasarkan nama yang dipilih di ComboBox
                            int idKategori;
                            using (var cmdKategori = new NpgsqlCommand("SELECT id_kategori FROM kategori WHERE nama_kategori = @nama_kategori AND is_deleted = FALSE", conn, trans))
                            {
                                cmdKategori.Parameters.AddWithValue("nama_kategori", cbKategori.SelectedItem.ToString());
                                var result = cmdKategori.ExecuteScalar();
                                if (result == null)
                                {
                                    throw new Exception("Kategori tidak ditemukan. Pastikan kategori valid.");
                                }
                                idKategori = Convert.ToInt32(result);
                            }

                            // Update data aplikasi
                            using (var cmdAplikasi = new NpgsqlCommand(
                                "UPDATE aplikasi SET nama_aplikasi = @nama_aplikasi, deskripsi_aplikasi = @deskripsi_aplikasi WHERE id_aplikasi = @id_aplikasi",
                                conn, trans))
                            {
                                cmdAplikasi.Parameters.AddWithValue("id_aplikasi", idAplikasi);
                                cmdAplikasi.Parameters.AddWithValue("nama_aplikasi", txtNamaAplikasi.Text.Trim());
                                cmdAplikasi.Parameters.AddWithValue("deskripsi_aplikasi", string.IsNullOrWhiteSpace(txtDeskripsiAplikasi.Text) ? (object)DBNull.Value : txtDeskripsiAplikasi.Text.Trim());

                                cmdAplikasi.ExecuteNonQuery();
                            }

                            // Update harga
                            using (var cmdHarga = new NpgsqlCommand(
                                "UPDATE harga SET id_kategori = @id_kategori, harga = @harga WHERE id_aplikasi = @id_aplikasi",
                                conn, trans))
                            {
                                cmdHarga.Parameters.AddWithValue("id_kategori", idKategori);
                                cmdHarga.Parameters.AddWithValue("id_aplikasi", idAplikasi);
                                cmdHarga.Parameters.AddWithValue("harga", Convert.ToDecimal(txtHarga.Text.Trim()));

                                cmdHarga.ExecuteNonQuery();
                            }

                            // Commit transaksi
                            trans.Commit();

                            MessageBox.Show("Update Berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Bersihkan input dan refresh data grid
                            txtNamaAplikasi.Clear();
                            txtDeskripsiAplikasi.Clear();
                            txtHarga.Clear();
                            cbKategori.SelectedIndex = 0;
                            LoadData();
                        }
                        catch
                        {
                            // Rollback jika ada error
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbDeleteAplikasi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAplikasi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih aplikasi yang ingin dihapus!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvAplikasi.SelectedRows[0];
                int idAplikasi = Convert.ToInt32(selectedRow.Cells["id_aplikasi"].Value);

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();

                    // Mulai transaksi untuk memastikan konsistensi data
                    using (var trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // Hapus data dari tabel harga
                            using (var cmdHarga = new NpgsqlCommand("DELETE FROM harga WHERE id_aplikasi = @id_aplikasi", conn, trans))
                            {
                                cmdHarga.Parameters.AddWithValue("id_aplikasi", idAplikasi);
                                cmdHarga.ExecuteNonQuery();
                            }

                            // Hapus data dari tabel aplikasi
                            using (var cmdAplikasi = new NpgsqlCommand("DELETE FROM aplikasi WHERE id_aplikasi = @id_aplikasi", conn, trans))
                            {
                                cmdAplikasi.Parameters.AddWithValue("id_aplikasi", idAplikasi);
                                cmdAplikasi.ExecuteNonQuery();
                            }

                            // Commit transaksi
                            trans.Commit();

                            MessageBox.Show("Delete Berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh data grid
                            LoadData();
                        }
                        catch
                        {
                            // Rollback jika ada error
                            trans.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackAplikasi_Click(object sender, EventArgs e)
        {
            FormDashobardAdmin dashobardAdminForm = new FormDashobardAdmin();
            dashobardAdminForm.Show();
            this.Hide();
        }
    }
}

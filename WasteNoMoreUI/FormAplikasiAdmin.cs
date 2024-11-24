using Npgsql;
using System;
using System.Data;
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

        private void pbInsertAplikasi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT add_aplikasi(@nama, @deskripsi);", conn))
                    {
                        // Bind parameter
                        cmd.Parameters.AddWithValue("nama", txtNamaAplikasi.Text);
                        cmd.Parameters.AddWithValue("deskripsi", txtDeskripsiAplikasi.Text);

                        // Eksekusi fungsi dan periksa hasilnya
                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Aplikasi berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            txtNamaAplikasi.Clear();
                            txtDeskripsiAplikasi.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Aplikasi gagal ditambahkan! Nama aplikasi mungkin sudah ada.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAplikasiAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Query SQL untuk mengambil data aplikasi
                string query = "SELECT id_aplikasi, nama_aplikasi, deskripsi_aplikasi FROM aplikasi";
                dt = DatabaseManager.ExecuteQuery(query);

                // Tampilkan data di DataGridView
                dgvAplikasi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbUpdateAplikasi_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris data yang akan diperbarui", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNamaAplikasi.Text))
            {
                MessageBox.Show("Nama aplikasi tidak boleh kosong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT update_aplikasi(@id, @nama, @deskripsi);", conn))
                    {
                        // Bind parameter
                        cmd.Parameters.AddWithValue("id", Convert.ToInt32(r.Cells["id_aplikasi"].Value));
                        cmd.Parameters.AddWithValue("nama", txtNamaAplikasi.Text.Trim());
                        cmd.Parameters.AddWithValue("deskripsi", string.IsNullOrWhiteSpace(txtDeskripsiAplikasi.Text) ? (object)DBNull.Value : txtDeskripsiAplikasi.Text.Trim());

                        // Eksekusi fungsi dan periksa hasilnya
                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Aplikasi berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            txtNamaAplikasi.Clear();
                            txtDeskripsiAplikasi.Clear();
                            r = null;
                        }
                        else
                        {
                            MessageBox.Show("Pembaruan aplikasi gagal! Pastikan data valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAplikasi(int idAplikasi)
        {
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT delete_aplikasi(@id_aplikasi);", conn))
                    {
                        cmd.Parameters.AddWithValue("id_aplikasi", idAplikasi);

                        // Eksekusi fungsi dan periksa hasilnya
                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Aplikasi berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aplikasi tidak ditemukan.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbDeleteAplikasi_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris data yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus aplikasi ini?", "Konfirmasi Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int idAplikasi = Convert.ToInt32(r.Cells["id_aplikasi"].Value);

                    // Panggil fungsi DeleteAplikasi untuk menghapus data
                    DeleteAplikasi(idAplikasi);

                    // Refresh DataGridView setelah penghapusan
                    LoadData();
                    txtNamaAplikasi.Clear();
                    txtDeskripsiAplikasi.Clear();
                    r = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBackAplikasi_Click(object sender, EventArgs e)
        {
            FormDashobardAdmin dashobardAdminForm = new FormDashobardAdmin();
            dashobardAdminForm.Show();
            this.Hide();
        }

        private void btnLoadAplikasi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvAplikasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvAplikasi.Rows[e.RowIndex];
                txtNamaAplikasi.Text = r.Cells["nama_aplikasi"].Value.ToString();
                txtDeskripsiAplikasi.Text = r.Cells["deskripsi_aplikasi"].Value.ToString();
            }
        }
    }
}

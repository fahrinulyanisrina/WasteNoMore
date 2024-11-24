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
    public partial class FormKategoriAdmin : Form
    {
        private DataTable dt;
        private DataGridViewRow r;
        private FormDashobardAdmin formDashobardAdmin;
        public FormKategoriAdmin(FormDashobardAdmin formDashobardAdmin)
        {
            InitializeComponent();
            this.formDashobardAdmin = formDashobardAdmin;
        }

        private void pbInsert_Click(object sender, EventArgs e)
        {

            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT add_kategori(@nama, @deskripsi);", conn))
                    {
                        // Bind parameter
                        cmd.Parameters.AddWithValue("nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text);

                        // Eksekusi fungsi dan periksa hasilnya
                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Kategori berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            txtNama.Clear();
                            txtDeskripsi.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Kategori gagal ditambahkan! Nama kategori mungkin sudah ada.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbUpdate_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris data yang akan diperbarui", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama kategori tidak boleh kosong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT update_kategori(@id, @nama, @deskripsi);", conn))
                    {
                        // Bind parameter
                        cmd.Parameters.AddWithValue("id", Convert.ToInt32(r.Cells["id_kategori"].Value));
                        cmd.Parameters.AddWithValue("nama", txtNama.Text.Trim());
                        cmd.Parameters.AddWithValue("deskripsi", string.IsNullOrWhiteSpace(txtDeskripsi.Text) ? (object)DBNull.Value : txtDeskripsi.Text.Trim());

                        // Eksekusi fungsi dan periksa hasilnya
                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Kategori berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            txtNama.Clear();
                            txtDeskripsi.Clear();
                            r = null;
                        }
                        else
                        {
                            MessageBox.Show("Pembaruan kategori gagal! Pastikan data valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                // Query SQL untuk mengambil data kategori
                string query = "SELECT id_kategori, nama_kategori, deskripsi_kategori FROM kategori";
                dt = DatabaseManager.ExecuteQuery(query);

                // Tampilkan data di DataGridView
                dgvKategori.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvKategori.Rows[e.RowIndex];
                txtNama.Text = r.Cells["nama_kategori"].Value.ToString();
                txtDeskripsi.Text = r.Cells["deskripsi_kategori"].Value.ToString();
            }
        }

        private void FormKategoriAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteKategori(int idKategori)
        {
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT delete_kategori(@id_kategori);", conn))
                    {
                        cmd.Parameters.AddWithValue("id_kategori", idKategori);

                        // Eksekusi fungsi dan periksa hasilnya
                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Kategori berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Kategori tidak ditemukan.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris data yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus kategori ini?", "Konfirmasi Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int idKategori = Convert.ToInt32(r.Cells["id_kategori"].Value);

                    // Panggil fungsi DeleteKategori untuk menghapus data
                    DeleteKategori(idKategori);

                    // Refresh DataGridView setelah penghapusan
                    LoadData();
                    txtNama.Clear();
                    txtDeskripsi.Clear();
                    r = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormKategoriAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDashobardAdmin.Show();
        }
    }
}

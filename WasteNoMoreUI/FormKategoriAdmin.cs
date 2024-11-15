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
        public FormKategoriAdmin()
        {
            InitializeComponent();
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
                        //bind parameter
                        cmd.Parameters.AddWithValue("nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text);

                        //eksekusi fungsi dan periksa hasilnya
                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Kategori berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //load ulang datagrid kategori
                            LoadData();
                            //mengosongkan textbox input
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

            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT update_kategori(@id, @nama, @deskripsi);", conn))
                    {
                        cmd.Parameters.AddWithValue("id", Convert.ToInt32(r.Cells["id_kategori"].Value));
                        cmd.Parameters.AddWithValue("nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kategori berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        txtNama.Clear();
                        txtDeskripsi.Clear();
                        r = null;
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
                // Query untuk mengambil data kategori
                string query = "SELECT * FROM kategori";
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
            // Panggil metode LoadData untuk mengambil data kategori
            LoadData();
        }

        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Mendapatkan data baris yang dipilih
            if (e.RowIndex >= 0)
            {
                r = dgvKategori.Rows[e.RowIndex];
                txtNama.Text = r.Cells["nama_kategori"].Value.ToString();
                txtDeskripsi.Text = r.Cells["deskripsi_kategori"].Value.ToString();
            }
        }

        private void FormKategoriAdmin_Load(object sender, EventArgs e)
        {
            // Muat data saat form pertama kali dibuka
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDashobardAdmin dashobardAdminForm = new FormDashobardAdmin();
            dashobardAdminForm.Show();
            this.Hide();
        }

        private void DeleteKategori(int idKategori)
        {
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT delete_kategori(@id_kategori)", conn))
                    {
                        cmd.Parameters.AddWithValue("id_kategori", idKategori);
                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Kategori berhasil dihapus!");
                        }
                        else
                        {
                            MessageBox.Show("Kategori tidak ditemukan atau sudah dihapus.");
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
                    string query = $"UPDATE kategori SET is_deleted = TRUE WHERE id_kategori = {idKategori}";
                    DatabaseManager.ExecuteQuery(query);

                    MessageBox.Show("Kategori berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}

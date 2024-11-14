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
                // Query untuk menambah kategori baru
                string query = $"INSERT INTO kategori (nama_kategori, deskripsi_kategori) VALUES ('{txtNama.Text}', '{txtDeskripsi.Text}')";
                DatabaseManager.ExecuteQuery(query);

                MessageBox.Show("Kategori berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Muat ulang data di DataGridView
                LoadData();
                txtNama.Clear();
                txtDeskripsi.Clear();
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
                // Query untuk mengupdate data kategori
                string query = $"UPDATE kategori SET nama_kategori = '{txtNama.Text}', deskripsi_kategori = '{txtDeskripsi.Text}' WHERE id_kategori = {r.Cells["id_kategori"].Value}";
                DatabaseManager.ExecuteQuery(query);

                MessageBox.Show("Kategori berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Muat ulang data di DataGridView
                LoadData();
                txtNama.Clear();
                txtDeskripsi.Clear();
                r = null;
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
    }
}

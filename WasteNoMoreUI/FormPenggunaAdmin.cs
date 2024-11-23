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
    public partial class FormPenggunaAdmin : Form
    {
        private DataTable dt;
        private DataGridViewRow r;

        public FormPenggunaAdmin()
        {
            InitializeComponent();
        }

        private void LoadDataPengguna()
        {
            try
            {
                string query = "SELECT id_pengguna, nama_pengguna, username_pengguna, email_pengguna FROM pengguna WHERE is_deleted = FALSE";
                dt = DatabaseManager.ExecuteQuery(query);

                dgvPengguna.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputFields()
        {
            txtNama.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void pbInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT add_pengguna(@nama, @email, @password, @role)", conn))
                    {
                        // Bind parameter
                        cmd.Parameters.AddWithValue("nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("username", txtUsername.Text);

                        // Eksekusi fungsi dan periksa hasilnya
                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Pengguna berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataPengguna();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Penambahan pengguna gagal! Email mungkin sudah terdaftar.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    using (var cmd = new NpgsqlCommand("SELECT update_pengguna(@id, @nama, @username, @password, @email)", conn))
                    {
                        // Bind parameter
                        cmd.Parameters.AddWithValue("id", Convert.ToInt32(r.Cells["id_pengguna"].Value));
                        cmd.Parameters.AddWithValue("nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("email", txtEmail.Text);

                        // Eksekusi fungsi dan periksa hasilnya
                        bool result = (bool)cmd.ExecuteScalar();

                        if (result)
                        {
                            MessageBox.Show("Pengguna berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataPengguna();
                            ClearInputFields();
                            r = null;
                        }
                        else
                        {
                            MessageBox.Show("Pembaruan pengguna gagal! Pastikan data valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris data yang akan dihapus", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus pengguna ini?", "Konfirmasi Hapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var conn = DatabaseManager.GetConnection())
                    {
                        conn.Open();
                        using (var cmd = new NpgsqlCommand("SELECT delete_pengguna(@id)", conn))
                        {
                            cmd.Parameters.AddWithValue("id", Convert.ToInt32(r.Cells["id_pengguna"].Value));

                            bool isDeleted = (bool)cmd.ExecuteScalar();

                            if (isDeleted)
                            {
                                MessageBox.Show("Pengguna berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataPengguna();
                                ClearInputFields();
                                r = null;
                            }
                            else
                            {
                                MessageBox.Show("Pengguna tidak ditemukan atau sudah dihapus.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataPengguna();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDashobardAdmin formDashobardAdmin = new FormDashobardAdmin();
            formDashobardAdmin.Show();
            this.Hide();
        }

        private void FormPenggunaAdmin_Load(object sender, EventArgs e)
        {
            LoadDataPengguna();
        }
    }
}

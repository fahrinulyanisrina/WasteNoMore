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
using Npgsql;

namespace WasteNoMoreUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Ambil input dari pengguna
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validasi input apakah kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Logika login untuk admin
            if (username == "admin" && password == "password123")
            {
                // Login sebagai admin
                MessageBox.Show("Login sebagai Admin berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Membuka FormAdmin jika login sebagai admin
                FormDashobardAdmin dashboardAdminForm = new FormDashobardAdmin();
                dashboardAdminForm.Show();
                this.Hide();
                return;
            }

            try
            {
                // Hubungkan ke database dan validasi pengguna
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM login_pengguna(@username, @password);", conn))
                    {
                        // Tambahkan parameter ke SQL
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        var result = cmd.ExecuteScalar();

                        // Jika result tidak null dan valid
                        if (result != null && (bool)result == true)
                        {
                            MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Membuka dashboard jika login sukses
                            FormDashboard dashboardForm = new FormDashboard();
                            dashboardForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi kesalahan
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister();
            registerForm.Show();
            this.Hide();
        }
    }
}

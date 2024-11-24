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
using BCrypt.Net;

namespace WasteNoMoreUI
{
    public partial class FormLogin : Form
    {
        private int curerntID = -1;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister(this);
            registerForm.Show();
            this.Close();
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

            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();

                    // Jika username adalah "admin", langsung arahkan ke dashboard admin tanpa memverifikasi password hash
                    if (username == "admin" && password == "password123")
                    {
                        MessageBox.Show("Login berhasil sebagai Admin!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        // Membuka dashboard admin jika login sebagai admin
                        FormDashobardAdmin dashboardAdminForm = new FormDashobardAdmin(this);
                        dashboardAdminForm.Show();
                        this.Hide();
                        return;
                    }

                    // Jika bukan admin, cek password hash di database
                    using (var cmd = new NpgsqlCommand("SELECT password_pengguna FROM pengguna WHERE username_pengguna = @username", conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);

                        var dbPasswordHash = cmd.ExecuteScalar()?.ToString();

                        if (dbPasswordHash != null)
                        {
                            // Verifikasi password input dengan hash password di database
                            if (BCrypt.Net.BCrypt.Verify(password, dbPasswordHash))
                            {


                                string quickQuery = "SELECT id_pengguna FROM pengguna WHERE username_pengguna = @username";

                                // Set up parameters
                                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>
{
    new NpgsqlParameter("@username", NpgsqlTypes.NpgsqlDbType.Text) { Value = username }
};

                                // Execute the query and get the result
                                object result = DatabaseManager.ExecuteScalarQueryParams(quickQuery, parameters);

                                // Check if the result is not null and then convert it
                                if (result != DBNull.Value && result != null)
                                {
                                    curerntID = Convert.ToInt32(result);
                                }

                                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Membuka dashboard pengguna biasa jika login berhasil
                                FormDashboard dashboardForm = new FormDashboard(curerntID, this);
                                dashboardForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username tidak ditemukan!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FormRegister registerForm = new FormRegister(this);
            registerForm.Show();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }
    }
}

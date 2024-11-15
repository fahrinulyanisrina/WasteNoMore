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
//import class
using WasteNoMoreUI.Models; 

namespace WasteNoMoreUI
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            //menganbil data dari textBox yg diinputkan user
            string namaPengguna = txtNamaPengguna.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //validasi input apakah ada yang kosong atau tidak
            if (string.IsNullOrEmpty(namaPengguna) || string.IsNullOrEmpty(email) ||
        string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                //jika ada, beri feedback
                MessageBox.Show("Semua data harus diisi!");
                return;
            }
            //validasi format email
            if (!IsEmailValid(email))
            {
                MessageBox.Show("Format email tidak valid!");
                return;
            }

            //menambahkan data pengguna ke db
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT add_pengguna(@nama, @username, @password, @email);", conn))
                    {
                        //parameter untuk perintah SQL
                        cmd.Parameters.AddWithValue("nama", namaPengguna);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.Parameters.AddWithValue("email", email);

                        //eksekusi perintah
                        var result = cmd.ExecuteScalar();

                        //memeriksa hasil
                        if (result != null && (int)result == 1)
                        {
                            MessageBox.Show("Akun berhasil dibuat!");
                            //membuka Form Login
                            FormLogin loginForm = new FormLogin();
                            loginForm.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Username atau email sudah terdaftar!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //kembali ke form login
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Hide();
        }

        private bool IsEmailValid(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}

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
//import
using BCrypt.Net;
using WasteNoMoreUI.Models; 

namespace WasteNoMoreUI
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private static string generatedOtp;
        private static DateTime otpSentTime;
        private static DateTime otpExpirationTime;

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

        private string GenerateOtp()
        {
            Random rand = new Random();
            return rand.Next(10000, 99999).ToString(); // Generate 5 digit OTP
        }

        private void SendOtp(string email)
        {
            // Generate OTP baru dan tentukan waktu kedaluwarsanya
            generatedOtp = GenerateOtp();
            otpSentTime = DateTime.Now;
            otpExpirationTime = otpSentTime.AddMinutes(5); // OTP berlaku selama 5 menit

            // Kirim email dengan OTP
            GmailServiceAPI.SendEmail(email, "Verification Code", $"Selamat datang di WasteNoMore! Verifikasi alamat email anda untuk membuat akun WasteNoMore dengan memasukkan kode OTP berikut. Kode OTP: {generatedOtp}. Terimakasih. Tim WasteNoMore");
        }
        private void btnOtp_Click(object sender, EventArgs e)
        {
            // Mengambil data dari textbox yang diinputkan user
            string namaPengguna = txtNamaPengguna.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validasi input apakah ada yang kosong atau tidak
            if (string.IsNullOrEmpty(namaPengguna) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                // Jika ada, beri feedback
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            // Validasi format email
            if (!IsEmailValid(email))
            {
                MessageBox.Show("Format email tidak valid!");
                return;
            }

            // Kirim OTP
            SendOtp(email);
            MessageBox.Show("Kode OTP telah dikirim ke email Anda.");
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // Mengambil data dari textbox yang diinputkan user
            string namaPengguna = txtNamaPengguna.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string inputOTP = tbOtp.Text; // Mengambil input OTP dari textbox

            // Validasi apakah ada data yang kosong
            if (string.IsNullOrEmpty(namaPengguna) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(inputOTP))
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            // Validasi format email
            if (!IsEmailValid(email))
            {
                MessageBox.Show("Format email tidak valid!");
                return;
            }

            // Cek apakah OTP masih valid
            if (DateTime.Now > otpExpirationTime)
            {
                MessageBox.Show("Kode OTP telah kedaluwarsa! Silakan kirim ulang OTP.");
                return;
            }

            // Cek apakah OTP yang dimasukkan sesuai dengan yang dikirim
            if (inputOTP != generatedOtp)
            {
                MessageBox.Show("Kode OTP salah! Silakan kirim kode OTP ulang.");
                tbOtp.Clear();
                return;
            }

            // Hash password menggunakan bcrypt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Menambahkan data pengguna ke database
            try
            {
                using (var conn = DatabaseManager.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand("SELECT add_pengguna(@nama, @username, @password, @email);", conn))
                    {
                        cmd.Parameters.AddWithValue("nama", namaPengguna);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", hashedPassword);
                        cmd.Parameters.AddWithValue("email", email);

                        var result = cmd.ExecuteScalar();

                        if (result != null && (int)result == 1)
                        {
                            MessageBox.Show("Akun berhasil dibuat!");
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

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnOtp_Click_1(object sender, EventArgs e)
        {
            // Mengambil data dari textbox yang diinputkan user
            string namaPengguna = txtNamaPengguna.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //membuka ke form login
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Hide();
        }

        private void lblJudul_Click(object sender, EventArgs e)
        {

        }

        private void lblJudul_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //membuka ke form login
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WasteNoMoreUI
{
    public partial class FormDashobardAdmin : Form
    {
        public FormDashobardAdmin()
        {
            InitializeComponent();
        }

        private void btnPengguna_Click(object sender, EventArgs e)
        {
            //ketika button Pengguna di-klik maka form pengguna dibuka
            FormPenggunaAdmin penggunaAdminForm = new FormPenggunaAdmin();
            penggunaAdminForm.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            //ketika button Kategori di-klik maka form kategori dibuka
            FormKategoriAdmin kategoriAdminForm = new FormKategoriAdmin();
            kategoriAdminForm.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void btnAplikasi_Click(object sender, EventArgs e)
        {
            //ketika button aplikasi di-klik maka form aplikasi dibuka
            FormAplikasiAdmin aplikasiAdminFrom = new FormAplikasiAdmin();
            aplikasiAdminFrom.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            //hapus data sesi pengguna
            SessionManager.ClearSession(); // Contoh fungsi pengelola sesi
            // Menampilkan form login
            FormLogin loginForm = new FormLogin();
            loginForm.Show();

            // Menutup form dashboard admin
            this.Close();
        }

        private void pbPengguna_Click(object sender, EventArgs e)
        {
            //ketika button Pengguna di-klik maka form pengguna dibuka
            FormPenggunaAdmin penggunaAdminForm = new FormPenggunaAdmin();
            penggunaAdminForm.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void pbKategori_Click(object sender, EventArgs e)
        {
            //ketika button Kategori di-klik maka form kategori dibuka
            FormKategoriAdmin kategoriAdminForm = new FormKategoriAdmin();
            kategoriAdminForm.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void pbAplikasi_Click(object sender, EventArgs e)
        {
            //ketika button aplikasi di-klik maka form aplikasi dibuka
            FormAplikasiAdmin aplikasiAdminFrom = new FormAplikasiAdmin();
            aplikasiAdminFrom.Show();
            //form dashboard ditutup
            this.Hide();
        }
    }
}

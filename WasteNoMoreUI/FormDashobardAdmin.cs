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
            //konfirmasi logout ke pengguna
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //jika pengguna memilih "Yes", maka proses logout dilanjutkan
            if (dialogResult == DialogResult.Yes)
            {
                //ketika button Logiut di-klik maka form login dibuka
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                //form dashboard ditutup
                this.Close();
            }
            //jika pengguna memilih "No", maka tetap di halaman dashboard
            else
            {

            }
        }

        private void btnHarga_Click(object sender, EventArgs e)
        {
            //ketika button Harga di-klik maka form Harga dibuka
            FormHargaAdmin hargaAdminFrom = new FormHargaAdmin();
            hargaAdminFrom.Show();
            //form dashboard ditutup
            this.Hide();
        }
    }
}

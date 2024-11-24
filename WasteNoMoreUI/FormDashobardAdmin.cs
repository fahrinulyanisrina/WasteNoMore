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
        private FormLogin formLogin;
        public FormDashobardAdmin(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //konfirmasi logout ke pengguna
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //jika pengguna memilih "Yes", maka proses logout dilanjutkan
            if (dialogResult == DialogResult.Yes)
            {
                //form dashboard ditutup
                this.Close();
            }
            //jika pengguna memilih "No", maka tetap di halaman dashboard
            else
            {

            }
        }

        private void pbPengguna_Click(object sender, EventArgs e)
        {
            //ketika button manajemen pengguna di-klik maka form manajemen pengguna dibuka
            FormPenggunaAdmin penggunaAdminForm = new FormPenggunaAdmin(this);
            penggunaAdminForm.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void pbKategori_Click(object sender, EventArgs e)
        {
            //ketika button manajemen Kategori di-klik maka form manajemen kategori dibuka
            FormKategoriAdmin kategoriAdminForm = new FormKategoriAdmin(this);
            kategoriAdminForm.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void pbAplikasi_Click(object sender, EventArgs e)
        {
            //ketika button manajemen aplikasi di-klik maka form manajemen aplikasi dibuka
            FormAplikasiAdmin aplikasiAdminFrom = new FormAplikasiAdmin(this);
            aplikasiAdminFrom.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void FormDashobardAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pbHarga_Click(object sender, EventArgs e)
        {
            //ketika button manajemen harga di-klik maka form manajemen harga dibuka
            FormHargaAdmin hargaAdminForm = new FormHargaAdmin(this);
            hargaAdminForm.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void FormDashobardAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin.Show();
            formLogin.txtPassword.Clear();
            formLogin.txtUsername.Clear();
        }
    }
}

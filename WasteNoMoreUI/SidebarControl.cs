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
    public partial class SidebarControl : UserControl
    {
        private int currentId;
        private bool sidebarExpand = false;

        public SidebarControl()
        {
            InitializeComponent();
            sidebar.Width = 100; // Set ukuran default
        }

        // Metode untuk menyetel ID pengguna saat ini
        public void SetCurrentId(int id)
        {
            currentId = id;
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 0)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 400)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void pbNavbar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnNavbarEntri_Click(object sender, EventArgs e)
        {
            // Navigasi ke FormEntriSampah
            FormEntriSampah form = new FormEntriSampah(currentId);
            form.Show();
            FindForm().Hide(); // Menutup form saat ini
        }

        private void btnNavbarTrack_Click(object sender, EventArgs e)
        {
            FormTrack form = new FormTrack(currentId);
            form.Show();
            FindForm().Hide();
        }

        private void btnNavbarBandingHarga_Click(object sender, EventArgs e)
        {
            FormBandingHarga form = new FormBandingHarga(currentId);
            form.Show();
            FindForm().Hide();
        }

        private void btnNavbarAkun_Click(object sender, EventArgs e)
        {
            FormDataPengguna form = new FormDataPengguna(currentId);
            form.Show();
            FindForm().Hide();
        }

        private void btnNavbarLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                FindForm().Close();
            }
        }

        private void btnNavbarDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard dashboardForm = new FormDashboard(currentId);
            dashboardForm.Show();
            this.Hide();
        }

        private void btnNavbarPanduan_Click(object sender, EventArgs e)
        {

        }
    }
}


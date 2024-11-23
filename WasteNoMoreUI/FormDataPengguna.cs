using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Import class
using WasteNoMoreUI.Models;

namespace WasteNoMoreUI
{
    public partial class FormDataPengguna : Form
    {
        int currentId = -1;
        bool sidebarExpand = false;

        public FormDataPengguna(int currentId)
        {
            InitializeComponent();
            this.currentId = currentId;
            LoadUserInfo();

            sidebar.Width = 100;
            sidebarExpand = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int currentId = this.currentId;
            string updateQuery = @"
            PDATE pengguna
            SET 
            nama_pengguna = COALESCE(@NamaPengguna, nama_pengguna),
            username_pengguna = COALESCE(@UsernamePengguna, username_pengguna),
            email_pengguna = COALESCE(@EmailPengguna, email_pengguna)
            WHERE id_pengguna = @IdPengguna;
            ";

            List<NpgsqlParameter> parameters = new List<NpgsqlParameter>
            {
                new NpgsqlParameter("@IdPengguna", currentId),
                new NpgsqlParameter("@NamaPengguna", tbNama.Text),
                new NpgsqlParameter("@UsernamePengguna", tbUsername.Text),
                new NpgsqlParameter("@EmailPengguna", tbEmail.Text)
             };

            try
            {
                //jika entri sampah berhasil dimasukkan
                DatabaseManager.ExecuteNonQueryWithParams(updateQuery, parameters);
                LoadUserInfo();
                MessageBox.Show("Data berhasil diupdate");
            }
            catch (Exception ex)
            {
                //setelah disimpan, kosongkan input
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserInfo()
        {
            string currentId = this.currentId.ToString();
            string query = $"SELECT nama_pengguna, username_pengguna, password_pengguna, email_pengguna FROM pengguna WHERE id_pengguna = {currentId}";

            DataTable dt = DatabaseManager.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                var pengguna = new Pengguna(
                    Convert.ToInt32(currentId),
                    row["nama_pengguna"].ToString(),
                    row["email_pengguna"].ToString(),
                    row["username_pengguna"].ToString(),
                    row["password_pengguna"].ToString()
                );

                lblNama.Text = pengguna.NamaPengguna;
                lblEmail.Text = pengguna.Email;
                lblUsername.Text = pengguna.Username;
            }


        }

        private void pbNavbar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnNavbarEntri_Click(object sender, EventArgs e)
        {
            //ketika button Entri Sampah di-klik maka form entri sampah dibuka
            FormEntriSampah inputSampahForm = new FormEntriSampah(currentId);
            inputSampahForm.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void btnNavbarTrack_Click(object sender, EventArgs e)
        {
            //ketika button Track Sampah di-klik maka form track sampah dibuka
            FormTrack formTrackSampah = new FormTrack(currentId);
            formTrackSampah.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void btnNavbarBandingHarga_Click(object sender, EventArgs e)
        {
            //ketika button Banding Harga di-klik maka form banidng harga dibuka
            FormBandingHarga formBandingHarga = new FormBandingHarga(currentId);
            formBandingHarga.Show();
            //form dashboard ditutup

            this.Hide();
        }

        private void btnNavbarAkun_Click(object sender, EventArgs e)
        {
            //ketika button data pengguna di-klik maka form data pengguna dibuka
            FormDataPengguna formDataPengguna = new FormDataPengguna(currentId);
            formDataPengguna.Show();
            //form dashboard ditutup
            this.Hide();
        }

        private void btnNavbarLogout_Click(object sender, EventArgs e)
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

        private void btnNavbarDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard dashboardForm = new FormDashboard(currentId);
            dashboardForm.Show();
            this.Hide();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) // Jika sidebar dalam keadaan terbuka
            {
                sidebar.Width -= 5; // Kurangi lebar sidebar secara bertahap
                if (sidebar.Width <= 100) // Jika lebar mencapai minimum
                {
                    sidebarExpand = false; // Tanda sidebar tertutup
                    sidebarTransition.Stop(); // Hentikan timer
                }
            }
            else // Jika sidebar dalam keadaan tertutup
            {
                sidebar.Width += 5; // Tambahkan lebar sidebar secara bertahap
                if (sidebar.Width >= 400) // Jika lebar mencapai maksimum
                {
                    sidebarExpand = true; // Tanda sidebar terbuka
                    sidebarTransition.Stop(); // Hentikan timer
                }
            }

            // Update ukuran panel lain jika perlu
            pnDashboard.Width = sidebar.Width;
            pnAkun.Width = sidebar.Width;
            pnBandingHarga.Width = sidebar.Width;
            pnEntri.Width = sidebar.Width;
            pnLogout.Width = sidebar.Width;
            pnPanduan.Width = sidebar.Width;
            pnTrack.Width = sidebar.Width;
        }
    }
}

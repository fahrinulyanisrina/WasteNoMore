using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//import class
using WasteNoMoreUI.Models;

namespace WasteNoMoreUI
{
    public partial class FormTrack : Form
    {
        private List<Kategori> kategoriList = new List<Kategori>();

        private FormDashboard formDashboard;

        private int currentId;
        public FormTrack(int currentId, FormDashboard formDashboard)

        bool sidebarExpand = false;
        public FormTrack(int currentId)

        {
            InitializeComponent();
            LoadKategori();
            this.currentId = currentId;

            this.formDashboard = formDashboard;


            sidebar.Width = 100;
            sidebarExpand = false;


        }

        private void LoadKategori()
        {
            // Query untuk mengambil data kategori yang belum dihapus
            string query = "SELECT id_kategori, nama_kategori, deskripsi_kategori FROM kategori WHERE is_deleted = FALSE";

            // Eksekusi query dan ambil data dari database
            DataTable dt = DatabaseManager.ExecuteQuery(query);

            // Membersihkan data lama di list dan combo box
            kategoriList.Clear();
            cmbKategori.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                var kategori = new Kategori(
                    Convert.ToInt32(row["id_kategori"]),
                    row["nama_kategori"].ToString(),
                    row["deskripsi_kategori"].ToString()
                );

                // Menambahkan kategori ke daftar dan combo box
                kategoriList.Add(kategori);
                cmbKategori.Items.Add(kategori.NamaKategori);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //akan membuka form dashboard
            this.Close();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            // Validasi input kategori
            if (cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Pastikan sudah memilih kategori!");
                return;
            }

            // Validasi waktu
            DateTime waktuAwal = dtpAwal.Value.Date;
            DateTime waktuAkhir = dtpAkhir.Value.Date;

            if (waktuAwal > waktuAkhir)
            {
                MessageBox.Show("Waktu awal tidak boleh lebih besar dari waktu akhir! Silakan pilih ulang waktunya.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil kategori terpilih
            var selectedKategori = kategoriList[cmbKategori.SelectedIndex];

            // Buka form grafik dan teruskan data
            FormGrafikTrack grafikForm = new FormGrafikTrack(selectedKategori, waktuAwal, waktuAkhir, currentId, this);
            grafikForm.Show();
            this.Hide(); // Sembunyikan form track saat ini
        }


        private void FormTrack_FormClosed(object sender, FormClosedEventArgs e)
        {
            formDashboard.Show();

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
    }
}

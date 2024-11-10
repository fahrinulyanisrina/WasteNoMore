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
//import class
using WasteNoMoreUI.Models;

namespace WasteNoMoreUI
{
    public partial class FormTrack : Form
    {
        public FormTrack()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //akan membuka form dashboard
            FormDashboard dashboardForm = new FormDashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            //mengambil data dari textbox
            string kategoriDipilih = cmbKategori.SelectedItem?.ToString();
            DateTime waktuAwal = dtpAwal.Value;
            DateTime waktuAkhir = dtpAkhir.Value;

            //validasi data/input
            if (string.IsNullOrEmpty(kategoriDipilih))
            {
                MessageBox.Show("Silakan pilih kategori sampah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (waktuAwal > waktuAkhir)
            {
                MessageBox.Show("Waktu akhir tidak boleh lebih dulu dari waktu awal! Silakan pilih ulang waktunya!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //membuka form Grafik Track dan mengambil argumen dari form ini.
            FormGrafikTrack tampilanTrackForm = new FormGrafikTrack();
            tampilanTrackForm.Show();
            this.Hide(); // Sembunyikan form track saat ini
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

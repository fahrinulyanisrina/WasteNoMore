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

        public FormTrack()
        {
            InitializeComponent();
            LoadKategori();
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
            // Membuka form dashboard
            FormDashboard dashboardForm = new FormDashboard();
            dashboardForm.Show();
            this.Hide();
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
            FormGrafikTrack grafikForm = new FormGrafikTrack(selectedKategori, waktuAwal, waktuAkhir);
            grafikForm.Show();
            this.Hide(); // Sembunyikan form track saat ini
        }
    }
}

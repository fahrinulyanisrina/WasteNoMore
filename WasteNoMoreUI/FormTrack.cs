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
        private int currentId;
        public FormTrack(int currentId)
        {
            InitializeComponent();
            LoadKategori();
            this.currentId = currentId;
        }

        private void LoadKategori()
        {
            //query untuk mengambil data kategori yang belum dihapus
            string query = "SELECT id_kategori, nama_kategori, deskripsi_kategori FROM kategori WHERE is_deleted = FALSE";

            //eksekusi query dan ambil data dari db
            DataTable dt = DatabaseManager.ExecuteQuery(query);

            //membersihkan data lama di list dan combo box
            kategoriList.Clear();
            cmbKategori.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                var kategori = new Kategori(
                    Convert.ToInt32(row["id_kategori"]),
                    row["nama_kategori"].ToString(),
                    row["deskripsi_kategori"].ToString()
                );

                //menambahkan kategori ke daftar dan combo box
                kategoriList.Add(kategori);
                cmbKategori.Items.Add(kategori.NamaKategori);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //akan membuka form dashboard
            FormDashboard dashboardForm = new FormDashboard(currentId);
            dashboardForm.Show();
            this.Hide();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            //validasi data/input
            if (cmbKategori.SelectedIndex == -1)
            {
                //jika ada yang belum terisi, tampilkan feedback
                MessageBox.Show("Pastikan sudah memilih kategori!");
                return;
            }

            DateTime waktuAwal = dtpAwal.Value;
            DateTime waktuAkhir = dtpAkhir.Value;
            if (waktuAwal > waktuAkhir)
            {
                MessageBox.Show("Waktu akhir tidak boleh lebih dulu dari waktu awal! Silakan pilih ulang waktunya!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selectedKategori = kategoriList[cmbKategori.SelectedIndex];
                int idKategori = selectedKategori.IdKategori;
                int idPengguna = 1;
                //membuka form Grafik Track dan mengambil argumen dari form ini.
                FormGrafikTrack tampilanTrackForm = new FormGrafikTrack();
                tampilanTrackForm.Show();
                this.Hide(); // Sembunyikan form track saat ini
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

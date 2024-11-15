using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//import class
using WasteNoMoreUI.Models;

namespace WasteNoMoreUI
{
    public partial class FormEntriSampah : Form
    {
        private List<Kategori> kategoriList = new List<Kategori>();

        public FormEntriSampah()
        {
            InitializeComponent();
            LoadKategori();
        }

        private void LoadKategori()
        {
            // Modifikasi query agar hanya mengambil kategori yang belum dihapus
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

                // Tambahkan kategori ke daftar dan combo box
                kategoriList.Add(kategori);
                cmbKategori.Items.Add(kategori.NamaKategori);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormDashboard dashboardForm = new FormDashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validasi input sudah terisi
            if (cmbKategori.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtBerat.Text))
            {
            //jika ada yang belum terisi, tampilkan feedback
                MessageBox.Show("Pastikan sudah memilih kategori dan masukkan jumlah sampah!");
                return;
            }
            //validasi tipe data yang dimasukkan dalam variable berat sampah
            if (!double.TryParse(txtBerat.Text, out double beratSampah) || beratSampah <= 0)
            {
            //jika tidak valid, tampilkan feedback
                MessageBox.Show("Berat sampah harus berupa angka yang valid!");
                return;
            }

            //Ambil id_kategori sesuai kategori dipilih
            var selectedKategori = kategoriList[cmbKategori.SelectedIndex];
            int idKategori = selectedKategori.IdKategori;
            int idPengguna = 1; 
            // Update sesuai dengan ID pengguna saat ini

            string insertQuery = $"INSERT INTO sampah (id_pengguna, id_kategori, kuantitas) VALUES ({idPengguna}, {idKategori}, {beratSampah})";

            try
            {
                //jika entri sampah berhasil dimasukkan
                DatabaseManager.ExecuteQuery(insertQuery);
                MessageBox.Show("Sampah berhasil disimpan!");
                cmbKategori.SelectedIndex = -1;
                txtBerat.Clear();
            }
            catch (Exception ex)
            {
                //setelah disimpan, kosongkan input
                MessageBox.Show("Error: " + ex.Message, "FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormEntriSampah_Load(object sender, EventArgs e)
        {

        }
    }
}

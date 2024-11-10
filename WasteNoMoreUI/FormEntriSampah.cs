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
        public FormEntriSampah()
        {
            InitializeComponent();
        }


        private void label5_Click(object sender, EventArgs e)
        {

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
            double beratSampah;
            if (!double.TryParse(txtBerat.Text, out beratSampah) || beratSampah <= 0)
            {
                //jika tidak valid, tampilkan feedback
                MessageBox.Show("Berat sampah harus berupa angka yang valid!");
                return;
            }

            //jika entri sampah berhasil dimasukkan
            MessageBox.Show("Sampah berhasil disimpan!");

            //setelah disimpan, kosongkan input
            cmbKategori.SelectedIndex = -1;
            txtBerat.Clear();
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

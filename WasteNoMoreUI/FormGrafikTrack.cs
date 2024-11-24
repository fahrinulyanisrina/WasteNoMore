using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WasteNoMoreUI.Models;
using Npgsql;

namespace WasteNoMoreUI
{
    public partial class FormGrafikTrack : Form
    {
        private int currentId;
        private Kategori kategori;
        private DateTime waktuAwal;
        private DateTime waktuAkhir;
        private Chart chart;

        public FormGrafikTrack(Kategori kategori, DateTime waktuAwal, DateTime waktuAkhir)
        {
            InitializeComponent();

            this.kategori = kategori;
            this.waktuAwal = waktuAwal;
            this.waktuAkhir = waktuAkhir;

            // Debugging: Menampilkan parameter yang dikirimkan
            MessageBox.Show($"Waktu Awal: {waktuAwal.ToString("yyyy-MM-dd HH:mm:ss")}\nWaktu Akhir: {waktuAkhir.ToString("yyyy-MM-dd HH:mm:ss")}", "Parameter Debug",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Panggil metode untuk menampilkan grafik
            TampilkanGrafik();
        }

        private void FormGrafikTrack_Load(object sender, EventArgs e)
        {


        }

        private void TampilkanGrafik()
        {
            // Membuat objek Chart baru hanya sekali
            if (chart == null)
            {
                chart = new Chart();

                // Menyesuaikan ukuran chart agar lebih kecil
                chart.Width = 1100; // Lebar chart
                chart.Height = 490; // Tinggi chart

                // Menyesuaikan posisi chart pada form
                chart.Location = new System.Drawing.Point(20, 75);

                // Membuat dan menambahkan ChartArea
                ChartArea chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);

                // Membuat dan menambahkan Series ke chart
                Series series = new Series($"Data {kategori.NamaKategori}")
                {
                    ChartType = SeriesChartType.Line // Grafik garis
                };
                chart.Series.Add(series);

                // Menambahkan chart langsung ke form
                this.Controls.Add(chart);
            }

            // Query untuk mengambil data berdasarkan kategori dan waktu
            string query = @"
    SELECT 
        DATE(waktu_entri) AS tanggal, 
        SUM(kuantitas) AS total_berat
    FROM sampah
    WHERE id_kategori = @idKategori 
      AND waktu_entri >= @waktuAwal::timestamp 
      AND waktu_entri <= @waktuAkhir::timestamp
    GROUP BY DATE(waktu_entri)
    ORDER BY tanggal";

            // Parameter untuk query
            var parameters = new List<NpgsqlParameter>
    {
        new NpgsqlParameter("@idKategori", kategori.IdKategori),
        new NpgsqlParameter("@waktuAwal", waktuAwal.Date), // Pastikan hanya tanggal yang dikirim
        new NpgsqlParameter("@waktuAkhir", waktuAkhir.Date)  // Pastikan hanya tanggal yang dikirim
    };

            // Eksekusi query dengan parameter
            DataTable dt = DatabaseManager.ExecuteQueryWithParams(query, parameters);

            // Buat list tanggal lengkap dari waktuAwal ke waktuAkhir
            Dictionary<DateTime, double> dataGrafik = new Dictionary<DateTime, double>();
            DateTime currentDate = waktuAwal.Date;

            while (currentDate <= waktuAkhir.Date)
            {
                dataGrafik[currentDate] = 0; // Inisialisasi semua tanggal dengan 0
                currentDate = currentDate.AddDays(1);
            }

            // Masukkan data dari database ke dictionary
            double totalSampah = 0; // Variabel untuk menghitung total sampah
            foreach (DataRow row in dt.Rows)
            {
                DateTime tanggal = Convert.ToDateTime(row["tanggal"]);
                double totalBerat = Convert.ToDouble(row["total_berat"]);
                dataGrafik[tanggal] = totalBerat; // Update nilai berat untuk tanggal tersebut
                totalSampah += totalBerat; // Tambahkan ke total sampah
            }

            // Tambahkan data ke chart dengan label
            chart.Series[0].Points.Clear();
            foreach (var item in dataGrafik)
            {
                // Tambahkan data ke grafik
                int pointIndex = chart.Series[0].Points.AddXY(item.Key.ToString("dd MMM yyyy"), item.Value);

                // Tambahkan label pada titik
                chart.Series[0].Points[pointIndex].Label = item.Value.ToString("F2"); // Format label menjadi dua angka desimal
                chart.Series[0].Points[pointIndex].Font = new System.Drawing.Font("Arial", 10); // Atur font label
            }

            // Tampilkan total sampah di textbox
            txtTotal.Text = totalSampah.ToString("F2") + " Kg";

            // Notifikasi jika grafik berhasil ditampilkan
            if (chart.Series[0].Points.Count > 0)
            {
                MessageBox.Show("Grafik berhasil ditampilkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tidak ada data yang ditemukan untuk grafik.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FormTrack trackForm = new FormTrack(currentId);
            trackForm.Show();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
        private int currentId;
        private FormTrack formTrack;

        public FormGrafikTrack(Kategori kategori, DateTime waktuAwal, DateTime waktuAkhir,int curerntId, FormTrack formTrack)
        {
            InitializeComponent();

            this.kategori = kategori;
            this.waktuAwal = waktuAwal;
            this.waktuAkhir = waktuAkhir;
            this.currentId = curerntId;
            this.formTrack = formTrack;
        }

        private void FormGrafikTrack_Load(object sender, EventArgs e)
        {
            // Membuat objek Chart baru
            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill; // Agar chart mengisi seluruh form

            // Membuat dan menambahkan ChartArea
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Membuat dan menambahkan Series ke chart
            Series series = new Series($"Data {kategori.NamaKategori}");
            series.ChartType = SeriesChartType.Line; // Grafik garis
            chart.Series.Add(series);

            series.Points.AddXY("17 Nov", 10);
            series.Points.AddXY("18 Nov", 20);
            series.Points.AddXY("19 Nov", 15);


            // Query untuk mengambil data
            string query = @"
                SELECT waktu_entri, SUM(kuantitas) AS total_berat
                FROM sampah
                WHERE id_kategori = @idKategori AND waktu_entri BETWEEN @waktuAwal AND @waktuAkhir
                GROUP BY waktu_entri
                ORDER BY waktu_entri";

            // Parameter untuk query
            var parameters = new List<NpgsqlParameter>
            {
                new NpgsqlParameter("@idKategori", kategori.IdKategori),
                new NpgsqlParameter("@waktuAwal", waktuAwal),
                new NpgsqlParameter("@waktuAkhir", waktuAkhir)
            };

            // Eksekusi query dengan parameter
            DataTable dt = DatabaseManager.ExecuteQueryWithParams(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                DateTime tanggal = Convert.ToDateTime(row["waktu_entri"]);
                double totalBerat = Convert.ToDouble(row["total_berat"]);

                // Debugging: Cek nilai data yang diambil
                Console.WriteLine($"Tanggal: {tanggal}, Total Berat: {totalBerat}");

                series.Points.AddXY(tanggal.ToString("dd MMM"), totalBerat);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            formTrack.Show();

            this.Close(); // Tutup form grafik
        }
    }
}

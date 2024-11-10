using System.Collections.Generic;

namespace WasteNoMore.Models
{
    public class BandingHarga
    {
        public Kategori Kategori { get; set; }
        public double Berat { get; set; }
        public Dictionary<string, double> DaftarHarga { get; set; }

        public BandingHarga(Kategori kategori, double berat)
        {
            Kategori = kategori;
            Berat = berat;
            DaftarHarga = new Dictionary<string, double>();
        }

        public void TambahHarga(string namaAplikasi, double harga)
        {
            DaftarHarga[namaAplikasi] = harga;
        }
    }
}

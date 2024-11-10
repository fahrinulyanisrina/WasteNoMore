namespace WasteNoMore.Models
{
    public class Sampah
    {
        public Kategori Kategori { get; set; }
        public double Jumlah { get; set; }
        public double Berat { get; set; }

        public Sampah(Kategori kategori, double jumlah, double berat)
        {
            Kategori = kategori;
            Jumlah = jumlah;
            Berat = berat;
        }
    }
}

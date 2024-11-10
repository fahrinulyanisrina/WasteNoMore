namespace WasteNoMore.Models
{
    public class Price
    {
        public string NamaAplikasi { get; set; }
        public double Harga { get; set; }

        public Price(string namaAplikasi, double harga)
        {
            NamaAplikasi = namaAplikasi;
            Harga = harga;
        }
    }
}

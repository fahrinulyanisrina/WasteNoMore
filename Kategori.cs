namespace WasteNoMore.Models
{
    public class Kategori
    {
        public int IdKategori { get; set; }
        public string NamaKategori { get; set; }
        public string DeskripsiKategori { get; set; }

        public Kategori(int idKategori, string namaKategori, string deskripsiKategori)
        {
            IdKategori = idKategori;
            NamaKategori = namaKategori;
            DeskripsiKategori = deskripsiKategori;
        }
    }
}

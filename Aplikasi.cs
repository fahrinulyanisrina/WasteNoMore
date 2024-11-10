namespace WasteNoMore.Models
{
    public class Aplikasi
    {
        public string NamaAplikasi { get; set; }
        public string DeskripsiApk { get; set; }

        public Aplikasi(string namaAplikasi, string deskripsiApk)
        {
            NamaAplikasi = namaAplikasi;
            DeskripsiApk = deskripsiApk;
        }
    }
}

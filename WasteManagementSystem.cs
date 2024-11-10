using System.Collections.Generic;

namespace WasteNoMore.Models
{
    public class WasteManagementSystem
    {
        private Database database; // Anda harus membuat kelas Database untuk menyimpan data

        public WasteManagementSystem(Database db)
        {
            database = db;
        }

        public void SignIn(Pengguna pengguna)
        {
            database.AddUser(pengguna);
        }

        public Pengguna Login(string username, string password)
        {
            var pengguna = database.GetUser(username);
            if (pengguna != null && pengguna.Password == password)
            {
                return pengguna; // Login berhasil
            }
            return null; // Login gagal
        }

        public void TambahSampah(Pengguna pengguna, Sampah sampah)
        {
            var tracking = database.GetTracking(pengguna); // Ambil tracking pengguna
            tracking.TambahSampah(sampah);
            database.SaveTracking(tracking); // Simpan tracking ke database
        }

        public double TrackSampah(Pengguna pengguna)
        {
            var tracking = database.GetTracking(pengguna);
            return tracking.TotalBeratSampah(); // Mengembalikan total berat sampah
        }

        public BandingHarga BandingkanHarga(Kategori kategori, double berat)
        {
            var bandingHarga = new BandingHarga(kategori, berat);
            var hargaList = database.GetPrices(kategori, berat); // Ambil harga dari database
            foreach (var harga in hargaList)
            {
                bandingHarga.TambahHarga(harga.NamaAplikasi, harga.Harga);
            }
            return bandingHarga;
        }
    }
}

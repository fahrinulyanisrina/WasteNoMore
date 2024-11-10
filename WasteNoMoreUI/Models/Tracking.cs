using System.Collections.Generic;
using System.Linq;

namespace WasteNoMoreUI.Models
{
    public class Tracking
    {
        public Pengguna Pengguna { get; set; }
        public List<Sampah> DaftarSampah { get; set; }

        public Tracking(Pengguna pengguna)
        {
            Pengguna = pengguna;
            DaftarSampah = new List<Sampah>();
        }

        public void TambahSampah(Sampah sampah)
        {
            DaftarSampah.Add(sampah);
        }

        public double TotalBeratSampah()
        {
            return DaftarSampah.Sum(s => s.Berat);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_ProjeOdevi_Market
{
    class Urun
    {
        public string urunAdi { get; set; }
        public string kategori { get; set; }
        public double fiyat { get; set; }
        public DateTime sonIndirimTarihi { get; set; }
        public int stok { get; set; }

        public Urun(string urunAdi, string kategori, double fiyat, int stok)
        {
            this.urunAdi = urunAdi;
            this.kategori = kategori;
            this.fiyat = fiyat;
            this.sonIndirimTarihi = new DateTime();
            this.stok = stok;
            
        }
    }
}

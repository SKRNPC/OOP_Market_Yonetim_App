using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_ProjeOdevi_Market
{
    class Personel
    {
        public string adSoyad { get; set; }
        public string pozisyon { get; set; }
        public int maas { get; set; }
        public string adres { get; set; }
        public int kalanYillikIzin { get; set; }
        public int kullanilanIzin { get; set; }
        public Personel(string adSoyad, string pozisyon, int maas, string adres)
        {
            this.adSoyad = adSoyad;
            this.pozisyon = pozisyon;
            this.maas = maas;
            this.adres = adres;
            kalanYillikIzin = 14;
            kullanilanIzin = 0;
        }
    }
}

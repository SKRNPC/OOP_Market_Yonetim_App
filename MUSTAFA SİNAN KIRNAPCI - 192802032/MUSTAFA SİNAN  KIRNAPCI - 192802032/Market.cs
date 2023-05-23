using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_ProjeOdevi_Market
{
    class Market
    {
        public string subeAdi { get; set; }
        public string adres { get; set; }
        public List<Personel> personeller { get; set; }
        public List<Urun> urunler { get; set; }
        public List<Tedarikci> tedarikciler { get; set; }
        public Market(string subeAdi, string adres)
        {
            this.subeAdi = subeAdi;
            this.adres = adres;
            personeller = new List<Personel>();
            urunler = new List<Urun>();
            tedarikciler = new List<Tedarikci>();
           
            tedarikciler.Add(new Tedarikci("Temizlik", "İstanbul Fatih"));
            tedarikciler.Add(new Tedarikci("Gıda", "İstanbul Bağcılar"));
            tedarikciler.Add(new Tedarikci("Haftalık Kampanya Ürünleri", "İstanbul Esenler"));
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYP_ProjeOdevi_Market
{
    class Tedarikci
    {
        public string urunKategori { get; set; }
        public string adres { get; set; }

        public Tedarikci(string urunKategori, string adres)
        {
            this.urunKategori = urunKategori;
            this.adres = adres;
            
        }
    }
}

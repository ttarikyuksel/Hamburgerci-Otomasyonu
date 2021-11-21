using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    public class Menu
    {
        public string MenuAdi { get; set; }

        public decimal MenuFiyati { get; set; }

        public Menu(string ad, decimal fiyat)
        {
            MenuAdi = ad;
            MenuFiyati = fiyat;
        }
        
        public override string ToString()
        {
            return MenuAdi + " Menü";
        }
    }
}

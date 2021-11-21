using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    public class Malzeme
    {
        public string MalzemeAdi { get; set; }
        public decimal MalzemeFiyati { get; set; }
        public Malzeme(string ad, decimal fiyat)
        {
            MalzemeAdi = ad;
            MalzemeFiyati = fiyat;
        }
    }
}

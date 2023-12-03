using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kütüphane
{
    internal class Kitap
    {
        public string KitapAdi { get; set; }
        public string KitapTürü { get; set; }
        public decimal Fiyat { get; set; }
        public int KitapSayfasi { get; set; }
        public Yazar yazari { get; set; }

    }
}

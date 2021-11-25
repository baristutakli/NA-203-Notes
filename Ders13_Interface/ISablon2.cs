using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface {
    enum Kategori {Otomobil, Emlak, Beyaz_esya, Mobilya }
    interface ISablon2 {
        string ID { get; set; }
        double Fiyat { get; set; }
        Kategori Kategori { get; set; }

        double GetFiyat();

        
    }
}

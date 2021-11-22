using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_OOP {
    class Ogretmen {
        public List<Ogrenci> ogrenciler;
        public string ad;
        public Ogretmen(string ad)
        {
            this.ad = ad;
            this.ogrenciler = new List<Ogrenci>();
        }
        

        public void OgrencileriYaz()
        {
            foreach (Ogrenci ogr in this.ogrenciler)
            {
                Console.WriteLine(ogr.adSoyad);
            }
       
        }

    }
}

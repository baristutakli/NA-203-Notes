using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_OOP {
    class Ogrenci {
        public string tc;
        public int OgrenciNo;
        public string adSoyad;
        public Ogretmen ogretmen;
        public Ogrenci(string tc, int numara, string adSoyad, Ogretmen ogrtmn)
        {
            this.tc = tc;
            this.OgrenciNo = numara;
            this.adSoyad = adSoyad;
            this.ogretmen = ogrtmn;


        }

        public void SınıfOgretmeniDegistir(Ogretmen ogretmen)
        {
            this.ogretmen = ogretmen;

        }


        public void BilgiYaz()
        {
            Console.WriteLine($"Tc :{this.tc}\t Öğrenci no: {this.OgrenciNo}\t Ad Soyad: {adSoyad}\t Öğretmen {this.ogretmen.ad}");
        }

    }
}

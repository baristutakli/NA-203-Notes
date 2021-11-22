using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_OOP {
    class Derslik {

        public int derslikNo;
        public string adi;
        public int kapasite;
        public int kat;
        public Ogretmen ogretment;


        // DerslikAtamaKontrol metodu olacak (ogretmen) -> öğretmenin öğrenci sayısı sınıf kapasitesinesııyorsa true yoksa false
        // DerslikAta(oğretmen) -> öğretmenin dersliği değiştiriliyor

        public Derslik(int derslikNo, string adi, int kapasite, int kat)
        {
            this.derslikNo = derslikNo;
            this.adi = adi;
            this.kapasite = kapasite;
            this.kat = kat;

        }

        public bool DerslikKontrol(Ogretmen ogrt)
        {

            if (ogrt.ogrenciler.Count <= kapasite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Öğretmenin öğrenci sayısı sınıf kapasitesine sığıyorsa
        public void DerslikAta(Ogretmen ogrt)
        {
            if (DerslikKontrol(ogrt))
            {


                this.ogretment = ogrt;

            }

        }

        // Derslik hocası
        public void Yaz()
        {
            Console.WriteLine($"{this.adi} dersliğin hocası : {this.ogretment.ad}");
        }


    }


}

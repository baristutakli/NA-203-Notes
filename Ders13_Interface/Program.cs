using System;

namespace Ders13_Interface {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // İnterface dersi 
            // interface lerde bir sınıf birden fazla interfaceten miras alabilir.
            /*
            Test nesne = new Test();
            nesne.Marka = " Honda";
            nesne.Model = "Civic";

            */


            Otomobil arb = new Otomobil(YakitTipi.Dizel, VitesTipi.Manual, KasaTipi.Kısa, 2000);
            arb.Marka = "BMW";
            arb.Model = "i7";
            arb.IlanN = 20;
            arb.IlanTarihi = DateTime.Now;
            arb.SigortaYap();
            Sigorta guncelle = new Sigorta();
            guncelle.SigortaYap(arb);




        }
    }
}

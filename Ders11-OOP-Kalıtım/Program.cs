using System;
using System.Threading;

namespace Ders11_OOP_Kalıtım {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Kalıtım notları
            AltClass nesne = new AltClass();
            nesne.AdSoyad = "Barış";// AltClass özelliği
            nesne.KayitTarihi = DateTime.Now;//Ana class özelliği

            nesne.IlanTarihiYaz();//Ana class metodu
            nesne.adSoyadYaz(); // Alt class metodu
            Thread.Sleep(5000);
            AltClass2 nesne2 = new AltClass2();
            nesne2.KayitTarihi = DateTime.Now;
            nesne2.IlanTarihiYaz();
            nesne2.Baslik = "Uygun fiyatlı olta satılır";
            nesne2.BaslikYaz();

        }
    }
}

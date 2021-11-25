using System;

namespace Ders10_OOP2_Encapsulation {
    enum Gunler {
        Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
    }

    class Program {

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            User user1 = new User();
            user1.AdSoyadDuzenle("Mehmet Demir");
            user1.Tel = "aaa";
            Console.WriteLine(user1.Tel);
            */


            // enum :  yukarıda oluşturduğumuz öğeler index atar

            Kuafor k1 = new Kuafor("Ben");
            k1.SakalTrasiYap();
            k1.SacTrasiYap();
            k1.CiltBakımıYap();
            k1.BilgiYaz();

            /*
             *Bir class a sealed eklediğimiz zaman o classtan kalıtım yapılamaz
             *
             *
             */

            /*
            *Polimorfizm
            *Kedi Tekir new Kedi()
            *tekir.SesCikar()
            *
            *Kopek kangal = new Kopek();
            *kangal.sesCıkar();
            *
            *Hayvan hayvan = new Hayvan();
            *hayvan = tekir;
            *hayvan.SesCıkar() ı çağıdrığımızda Hayvan klasının özelliklerini kullanır
            *
            *
            *Eğer virtual dersek hayvan tekirin özelliklerini de kullanır
            *bu şekilde alttaki sınıf özelliğni kaybetmedi
            *
            *virtual tanımlanırken parametre sayıları eşit olmalıdır.
            *
            *örneğin bir fonksiyon hayvan nesnesi aldığında biz kedi de kopekte parametre olarak verebiliriz. 
            *Ne kedi ne de kopek özelliklerini kaybetmez.
            *
            */

        }

    }
}

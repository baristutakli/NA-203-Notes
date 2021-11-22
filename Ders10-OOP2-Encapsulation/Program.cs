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
            
         
            
        }


    }
}

using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args)
        {

            Console.Write("Ad Soyad:");
            string adSoyad = Console.ReadLine();
            Console.Write("E-posta:");
            string eposta = Console.ReadLine();
            Console.Write("Parola:");
            String parola = Console.ReadLine();

            Console.WriteLine($" Ad Soyad bilgileriniz: {adSoyad}\n E-posta adresiniz: {eposta} \n parolanız: {parola}");

            //reference types
            object genelDegisken = 999;
            genelDegisken = 23.23f;
            genelDegisken = 3.1D;
            genelDegisken = "merhaba";
            Console.WriteLine(genelDegisken);

            String referenceTipli = "Bu değişken doğrudanString sınıfından üretilmiştir. Yani bu kısımda nene olarak düşünebiliriz.";

            string degerTipli = "Bu değişken strin sınıfından türetilmeil strin deger tipidir.";

            var adres = "kadikoy";
            /// adres = 15; hata verir
        }
    }
}

using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args)
        {
                      // Tek satır açıklama/yorum/comment

            /*
             * Çoklu
             * Açıklama satırı
             */
            
            // Değer Tipi Değişkenler*******************************
            // Tip Ad = Veri;

            //sbyte sayi = -45;
            //sayi = 45;
            //byte bSayiMaks = byte.MaxValue;
            //byte bSayiMin = byte.MaxValue;
            //Console.WriteLine($"byte tipinin alacağı en büyük değer: {bSayiMaks}");
            //Console.WriteLine($"byte tipinin alacağı en küçük değer: {bSayiMin}");

            //short shortSayiMaks = short.MaxValue;
            //short shortSayiMin = short.MinValue;
            //Console.WriteLine($"short tipinin alacağı en büyük değer: {shortSayiMaks}");
            //Console.WriteLine($"short tipinin alacağı en küçük değer: {shortSayiMin }");

            //int intSayiMaks = int.MaxValue;
            //int intSayiMin = int.MinValue;
            //Console.WriteLine($"int tipinin alacağı en büyük değer: {intSayiMaks}");
            //Console.WriteLine($"int tipinin alacağı en küçük değer: {intSayiMin }");

            //long longSayiMaks = long.MaxValue;
            //long longSayiMin = long.MinValue;
            //Console.WriteLine($"long tipinin alacağı en büyük değer: {longSayiMaks}");
            //Console.WriteLine($"long tipinin alacağı en küçük değer: {longSayiMin }");

            //float floatSayiMaks = float.MaxValue;
            //float floatSayiMin = float.MinValue;
            //float floatSayi = 3.14f;

            //double doubleSayi = 124878.14D;
            //Console.WriteLine($"doubleSayi = {doubleSayi}");

            //decimal decMaks = decimal.MaxValue;
            //decimal decSayi = 3333.2222M;
            //Console.WriteLine($"decimal maks value:{decMaks}");
            //Console.WriteLine($"decSayi : {decSayi}");

            //char harf = 'A';
            //string isim = "Ali GÜNER";

            //Console.WriteLine($"harf değişkenin tipi: {harf.GetType()}");


            //// OTOMATİK TİP BELİRLEME //
            //var s1 = 55; // program derlenirken int s1 = 55;
            //var s2 = 34.23; // program derlenirken double s2 = 34.23;
            //var isim2 = "Gülşen"; // program derlenirken string isim2 = "Gülşen";
            //Console.WriteLine($"s1 değişkenin tipi: {s1.GetType()}");
            //Console.WriteLine($"s2 değişkenin tipi: {s2.GetType()}");
            //Console.WriteLine($"isim2 değişkenin tipi: {isim2.GetType()}");

            //bool kontrol = true;
            //kontrol = false;
            ////kontrol = 20; // hatalı veri tipi atandığı için çalışmaz.

            //// ÖRNEK:

            //Console.Write("Ad Soyad Giriniz : ");
            //string adSoyad = Console.ReadLine(); // Klavyeden veri almak için.
            //Console.WriteLine(adSoyad);

            ////Klavyeden girilen adSoyad Eposta Parola bilgilerini tek bir
            ////Console.WriteLine(); ile
            ////alt alta yazınız.

            //Console.Write("Ad soyad : ");
            //string adS = Console.ReadLine();
            //Console.Write("Eposta : ");
            //string eposta = Console.ReadLine();
            //Console.Write("Parola : ");
            //string parola = Console.ReadLine();

            //Console.WriteLine("Ad Soyad : " + adS + "\nEposta : " + eposta + "\nParola : " + parola);
            //Console.WriteLine($"Ad Soyad : {adS}\nEposta : {eposta}\nParola : {parola}");



            // REFERANS TİPİ VERİLER //
            // Ram'deki adres bilgisini tutar.
            // Tüm tiplerdeki veriyi saklayabilir.
            object genelDegisken = 999;
            Console.WriteLine(genelDegisken);
            genelDegisken = 23.23F;
            Console.WriteLine(genelDegisken);
            genelDegisken = 3.14D;
            Console.WriteLine(genelDegisken);
            genelDegisken = "Merhaba Dünya";
            Console.WriteLine(genelDegisken);

            // Referans Tipli String
            String referansTipli = "Bu değişken doğrudan String sınıfından üretilmiştir.";
            
            // Değer Tipli string
            string degerTipli = "Bu değişken String sınıfından türetilmiş string değer veri tipindedir.";

            // var ilk atanan tipte veri bekler. Farklı tipte veriler tutamaz.
            // program derlendiğinde içinde hangi veri var ise o tippe dönüşür.
            //var adres = "Kadıköy";
            //adres = 73; // HATALI ATAMA !!
            /*
            Console.Write("Ad Soyad:");
            string adSoyad = Console.ReadLine();

            Console.Write("E-posta:");
            string eposta = Console.ReadLine();

            Console.Write("Parola:");
            String parola = Console.ReadLine();
            Console.WriteLine($" Ad Soyad bilgileriniz: {adSoyad}\n E-posta adresiniz: {eposta} \n parolanız: {parola}");
            */
            //reference types
            object genelDegisken = 999;
            genelDegisken = 23.23f;
            genelDegisken = 3.1D;
            genelDegisken = "merhaba";
            //Console.WriteLine(genelDegisken);

            String referenceTipli = "Bu değişken doğrudanString sınıfından üretilmiştir. Yani bu kısımda nene olarak düşünebiliriz.";
            string degerTipli = "Bu değişken strin sınıfından türetilmeil strin deger tipidir.";

            var adres = "kadikoy";
            /// adres = 15; hata verir
            /// x
       

        }
    }
}

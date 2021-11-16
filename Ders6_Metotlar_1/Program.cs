using System;
using System.Collections.Generic;

namespace Ders6_Metotlar_1 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ders6 Metotlar");



            // Nesne üzerinden method çağırma
            // Program p new Program();
            // p.MerhabaDunya();
            int toplam = Sum(3,5); // Sum metodundan döndürülen değer toplam değişkenine atandı
            MerhabaDunya();
            Console.WriteLine(toplam);

            string deger = "Merhaba";
            TekrarYaz(deger);


            /*
            // Karesini alan fonksiyon
            Console.Write("Sayı giriniz : ");
            int deger2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{deger2}'nin karesi : {KaresiniAL(deger2)}");*/


            /*
            // KDVli fiyat
            double fiyat = 100d;
            Console.WriteLine("KDV eklenmiş fiyat : "+KdvliFiyat("gıda",fiyat));
            // KDVli fiyat
            double fiyat2 = 1200d;
            Console.WriteLine("KDV eklenmiş fiyat : " + KdvliFiyat("egitim", fiyat));
            // KDVli fiyat
            double fiyat3 = 1200d;
            Console.WriteLine("KDV eklenmiş fiyat : " + KdvliFiyat("", fiyat));*/


            // sayı gir
            // Console.WriteLine("Girilen sayi : "+sayiGir());


            // Faktoriel Hesaplama
            Console.WriteLine(faktorielHesapla(5));
            Console.WriteLine(faktorielHesapla(5.3d));


            // Asal mı
            bool isPrime = asalMi(15);
            Console.WriteLine($"15 asal mı : {isPrime}");
            bool isPrime2 = asalMi(19);
            Console.WriteLine($"19 asal mı : {isPrime2}");

            Console.WriteLine("-------------");
            // rastgele 10 sayı dizisi
            int[] rastgele10 = Random10();
            foreach (var item in rastgele10)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("");


            Console.WriteLine("-------------");
            // dizinin elemanlarını yazma
            int[] dizi1 = new int[5]
            {
                1,2,3,5,6
            };
            Yaz(dizi1);
            Console.WriteLine("");

            Console.WriteLine("-------------");
            //Tekleri döndüren metod
            Yaz(tekSayiDizisi(dizi1));
            Console.WriteLine("");


            Console.WriteLine("-------------");
            Console.WriteLine(Buyuktur(5, 4));
            Console.WriteLine(Buyuktur(5, 4,8));


            Console.WriteLine("-------------");
            List<int> nList = new List<int>() { 1, 2, 34, 5, 6 };
            foreach (var item in KareList(nList))
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine("");



            Console.WriteLine("-------------");
            foreach (var item in listGenerator())
            {
                Console.WriteLine("list"+ item);
            }
            


        }



       static void MerhabaDunya()
        {
            Console.WriteLine("Merhaba Dunya!");
        }


 
        // Kendisine gönderilen 2 sayıyı toplayıp döndüren metot
        static int Sum(int s1, int s2)
        {

            return s1+s2; // veri  geri döndürebiliriz
        }


        static void TekrarYaz(string  str)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(str);
            }
        }


        //Kendisine gönderilen int tipindeki sayının karesini geri döndiren programı yazınız
        static int KaresiniAL(int s1)
        {
            return s1 * s1;
        }


        // Kendisine girilen fiyatı %18 kdv ekleyip geri döndüren metodu yazınız
        // return titi : double, parametre tipi double

        static double KdvliFiyat( double s1)
        {
            double kdv = (s1 * 0.18d);
            return s1 + kdv;
        }


        static double KdvliFiyat(string type, double s1)
        {
            double result = s1;
            double kdv;
            if (type == "gıda")
            {
               kdv = (s1 * 0.08d);
            }
            else if (type == "egitim")
            {
                kdv = (s1 * 0.05d);
            }
            else
            {
                return KdvliFiyat(s1);
            }
            result += kdv;
            return result;
        }

        // yukarıdaki metoda ek olarak 
        // ürün tipine gör ekdv eklenecek ürüntipi string olacak
        // gıda %8 eğitim %5 diğerleri %18



        // SAyı girişini otomatikleştiren bir metodu yazınız
        // int sati= sayigir() // çagırdığımda otomatikmen sayı isteyecek
        // 

        static int sayiGir()
        {
            Console.Write("Sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            return sayi;
        }


        // parametre olarak aldığı sayınınn faktoriyelini  döndüren metodu yazınız
        // int, double tiplerinde veri alabilsin

        static int faktorielHesapla(int s1)
        {
            
            if (s1 == 1)
            {
                return s1;
            }
            else
            {
                return s1 * faktorielHesapla(s1 - 1);
            }
        }


        static double faktorielHesapla(double s1)
        {
            int intSayi = Convert.ToInt32(s1);
            
            if (intSayi == 1)
            {
                return intSayi;
            }
            else
            {
                return intSayi * faktorielHesapla(intSayi - 1);
            }
        }


        // Parametre olarak aldığı sayının asal olup olmadığını döndüren method. Asal ise true değilse false

        static bool asalMi(int s1)
        {
            if (s1== 2)
            {
                return true;
            }
            for (int i = 2; i < s1; i++)
            {
                if(s1%i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        // rastgele ürettiği 10 sayıyı int tipinde dizi olarak döndüren metodu tanımlayınız

        static int[] Random10()
        {
            int[] sayiDizisi = new int[10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                sayiDizisi[i] = r.Next(100);
            }
            return sayiDizisi;
        }


        // Kendisine parametre olarak gönderilen dizinin elemanlarını ekrana yazdıran metodu tanımlayın

        static void Yaz(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]+ " ");
            }
        }


        // Kendisine gönderilen dizideki tek sayıları yine dizi ile döndüren metod

        static int[] tekSayiDizisi(int[] karmaDizi)
        {
            
            int[] tekler = new int[karmaDizi.Length];
            for (int i = 0; i < karmaDizi.Length; i++)
            {
                if (karmaDizi[i]%2 == 1 )
                {
                    tekler[i] = karmaDizi[i];
                }
                
            }
            
            return tekler;
        }


        // parametre olarak aldığı iki sayıdan büyük olanı döndüren metodu yazınız

        static int Buyuktur(int s1, int s2)
        {
            int buyuk =s1;
            if (s1>s2)
            {
                buyuk= s1;

            }
            else if (s2>s1)
            {
                buyuk = s2;
            }
            return buyuk;
        }


        // parametre olarak aldığı 3 adet sayıdan en büyük olanı döndüren metod
        static int Buyuktur(int s1, int s2, int s3)
        {
            int b2li = Buyuktur(Buyuktur(s1,s2), s3);
            return b2li;
        }


        // List tipinde aldığı 10 adet sayının karelerinin list tipinde döndüren metodu yazınız

        static List<int> KareList(List<int> l)
        {
            List<int> list = new List<int>();
            foreach (var item in l)
            {
                list.Add(item * item);
            }
            return list;
        }


        // liste sorusu: kullanıcıdan 10 sayı alıp listeye ekle ve listeyi döndür

        static List<int> listGenerator()
        {
            List<int> nlist = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                nlist.Add(sayiGir());
            }
            return nlist;
        }






    }
}

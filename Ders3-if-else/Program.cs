using System;

namespace Ders3_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");

            Console.Write("Sayi : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool kontrol = sayi > 5;
            if (kontrol == true)
            {
                Console.WriteLine("Sayı beşten büyüktür.");

            }
            else
            {
                Console.WriteLine("sayı beşten küçük");
            }*/

            // klavyeden girilen 2 sayıdan büyük olanı ekrana yazdıran programı yazınız

            /*
            Console.Write("İlk sayi:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayi:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1> num2)
            {
                Console.WriteLine($"Büyük olan sayi :{num1}");
            }
            else if(num1 < num2)
            {
                Console.WriteLine($"Büyük olan sayi :{num2}");
            }
            else
            {
                Console.WriteLine("İki sayı eşit");
            }*/

            ///////////////////////////
            // ikinci soru klavyeden girilen üç sayıdan 100'den küçük olanları toplayıp yazdıran programı yazınız
            /*
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{i+1}. sayıyı giriniz : ");
                int num4 = Convert.ToInt32(Console.ReadLine());
                if (num4<100)
                {
                    sum += num4;
                }
            }
            Console.WriteLine($"Toplam : {sum}");*/

            // Aşağıdaki koşullara göre harf'e çeviren programı yazınız.
            /*
             *0-49: F
             *50-64: D
             *65-69: C
             *70-84: B
             *85-100: A
             
             
            Console.Write("Sınav notunuzu giriniz : ");
            int notun = Convert.ToInt32(Console.ReadLine());
            if (0 < notun && notun< 49)
            {
                Console.WriteLine($"Harf notunuz : F");
            }
            else if (50 < notun && notun < 64)
            {
                Console.WriteLine($"Harf notunuz : D");
            }
            else if (65 < notun && notun < 69)
            {
                Console.WriteLine($"Harf notunuz : C");
            }
            else if (70 < notun && notun < 84)
            {
                Console.WriteLine($"Harf notunuz : B");
            }
            else if (85 < notun && notun < 100)
            {
                Console.WriteLine($"Harf notunuz : A");
            }
            else
            {
                Console.WriteLine($"Notu yanlış girdiniz.");
            }
            */

            // Soru: Aşağıdaki kontrol programını yazınız.
            // Klavyeden 2 sayı alınız.
            // Klavyeden işlem bilgisi alınız
            //(işlem => topla, çıkar, çarp, bol
            // işleme göre girilen değerleri işleme sokan program
            /*
            Console.Write("İlk sayıyı giriniz : ");
            float s1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz : ");
            float s2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Yapılacak işlemi giriniz(topla, çıkar, bol, çarp): ");
            string islem = Console.ReadLine();
            string sonuc = "";
            if(islem == "topla")
            {
                sonuc = Convert.ToString(s1 + s2);
                Console.WriteLine($"Toplama işlemi sonucu:{sonuc} ");
            }
            else if (islem == "çıkar")
            {

                sonuc = Convert.ToString(s1 - s2);
                Console.WriteLine($"Çıkarma işlemi sonucu:{sonuc} ");
            }
            else if (islem == "bol")
            {
                if (s2 != 0)
                {
                    sonuc = Convert.ToString(s1 / s2);
                    Console.WriteLine($"Bölme işlemi sonucu:{sonuc} ");
                }
                else
                {
                    Console.WriteLine("Sıfıra bölünme hatası girdiniz. ");
                }
                
                
            }
            else if (islem == "çarp")
            {
                sonuc = Convert.ToString(s1 * s2);
                Console.WriteLine($"Çarpma işlemi sonucu:{sonuc} ");
            }
            else
            {
                Console.WriteLine("Tanımlanmamış bir işlem girdiniz. ");
            }
            */


            // Klvayeden girilen sayı çift ise ekrana yazdırsın tek ise 3'ün katı mı değil mi kontrol edilsin.
            /*
            Console.Write("İlk sayıyı giriniz : ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            if(s1 %2 == 0)
            {
                Console.WriteLine("Çift");
            }
            else
            {
                if (s1 %3 == 0)
                {
                   
                    Console.WriteLine($"{s1} üç sayısının {s1 / 3}");
                    
                }
            }
            */

            // Soru: Klavyeden girilen 5 sayıdan kaçının pozitif kaçının negatid olduğunu sayan ayrıca negatiflerin toplamı
            // ve pozitiflerin toplamını yazdıran program
            /*
            int negatifToplam = 0;
            int pozitifToplam = 0;
            int negatifSayiAdedi = 0;
            int pozitifSayiAdedi = 0;

            for (int i = 0; i < 5; i++)
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi>0)
                {
                    pozitifSayiAdedi += 1;
                    pozitifToplam += sayi;
                }
                else if (sayi<0)
                {
                    negatifSayiAdedi += 1;
                    negatifToplam += sayi;

                }

            }
            Console.WriteLine($"Pozitif sayi adedi: {pozitifSayiAdedi}\t Pozitif sayıların toplamı: {pozitifToplam}\n" +
                $"Negatif sayi adedi: {negatifSayiAdedi}\t Negatif sayıların toplamı: {negatifToplam} ");

            */

            // faktoriel ekrana yazdıran program
            /*int rakam = 5;
            int count = 1;
            int faktoriel = 1;
        Etiket:
   
            count++;
            faktoriel *=count;

            if (count<rakam)
            {
                goto Etiket;
            }
        Console.WriteLine(faktoriel);*/


            // kuvvet hesaplama
            /*
               int taban = 9;
               int us = 3;
               int sonuc = 1;

           kuvvetHesapla:
               us--;
               sonuc *= taban;
               if (us > 0)
               {
                   goto kuvvetHesapla;
               }
           Console.WriteLine(sonuc);

               */
            // klavyeden girilen sayı sıfır ile yüz arasında değilse tekrar isteyen programı  yazınız
            //  yukarıdaki şekilde 3 sayı alıp bunların aritmetik ortalaması

            /*
            int s1 = 4;
          
            int ortalama = 0;
        Hesapla:
            if(0<s1 && s1 < 100)
            {
                int s2 = 55;
                if (0 < s2 && s2 < 100)
                {
                    int s3 = 60;
                    if (0 < s3 && s3 <100)
                    {
                        ortalama = (s1 + s2 + s3) / 3;
                    }
                    else { goto Hesapla; }

                }
                else { goto Hesapla; }
            }
            else { goto Hesapla; }
        Console.WriteLine(ortalama);
            */

            //////////////////////////
            ///switch Case ////////////
            /////////////////////
            /*
            string seviye = "kolay";
            switch (seviye)
            {
                case "kolay":
                    Console.WriteLine("Seviye kolay");
                    break;
                case "orta":
                    Console.WriteLine("Seviyeniz orta");
                    break;// işlem bittikten sonra switch ten çıkmaya yarayacak
                case "zor":
                    Console.WriteLine("Seviyeniz zor");
                    break;
                default:
                    Console.WriteLine("Seviye hatalı!");
                    break;
        }

            */

            // Klavyeden 2 sayı ve işlem bilgisi alıp 
            // switch kullanarak toplama bome çıkarma çarpma yap

            Console.Write("Sayı giriniz:");
            float s1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Sayı giriniz:");
            float s2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("İşlemi giriniz(topla, cıkar, carp, bol):");
            string islem = Console.ReadLine();

            switch (islem)
            {
                case "topla":
                    Console.WriteLine(s1 + s2);
                    break;
                case "cıkar":
                    Console.WriteLine(s1 - s2);
                    break;
                case "carp":
                    Console.WriteLine(s1 * s2);
                    break;
                case "bol":
                    Console.WriteLine(s1 / s2);
                    break;

                default:
                    Console.WriteLine("İşlem hatalı girildi!");
                    break;
            }



        }
    }
}

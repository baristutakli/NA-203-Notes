using System;

namespace Ders4_DoWhile {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // do while döngüsünde döngü blogu koşula bakılmaksızın çalıştırılır. sonraki çalışmalar için koşul kontrol edilir.

            /*
             *do{}
             *while(true){
             *}
             *
             *Örn: klabyeden alınan sayıları toplayıp ekrana yaz
             * q denildiğinde çık
             **/
            /*
            int toplam = 0;
            int s;

            do
            {
                Console.WriteLine("Sayi : ");
                s = Convert.ToInt32(Console.ReadLine());
                toplam += s;

            } while (s != 0); // do yaptıktan sonra eğer sıfıra eşit değilse  sürekli devam eder

            Console.WriteLine("Toplam: " + toplam);*/



            // Soru : Kullanıcıdan eposta ve parola bilgisi alıp kontrol edecek programı yazınız
            // eposta : networkakademi.net parola= parola123
            /*
            string posta;
            string parola;
            do
            {
                Console.Write("Posta: ");
                posta = Console.ReadLine();
                Console.Write("Parola: ");
                parola = Console.ReadLine();
            } while (posta != "net" || parola != "parola123");*/

            /// eposta ve parola doğru olana kadar || sürekli tekrar edecek
            /// 


            ///////////////////////////////////
            ///For loop////////////////
            //////////////////////////////////
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Sayı: {i}");
            }

            Console.WriteLine("Sayi: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {
                if (i%2 ==0)
                {
                    Console.WriteLine(i);
                }
            }

            */
            // Sonsuz döngü
            /* for (; ; )
             {
                 Console.WriteLine("Sonsuz döngü.");

             }*/

            /*
            for (; ; )
            {
                Console.WriteLine("Çıkmak için Ç'ye basın.");
                string harf = Console.ReadLine();
                if (harf.ToUpper() == "Ç")
                {
                    break;

                }
            }*/

            // Soru : klavyeden girilen 2 sayı arasındaki sayıları azalan şekilde yazan programı yazınız
            // büyük sayıyı ve küçük sayıyı otomatik seçecek
            /*
            Console.WriteLine("Sayı giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            if (s1>s2)
            {
                Console.WriteLine($"{s1} den {s2}'ye doğru azalarak devam edecek");
                for (int i = s1; s2 <= i; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine($"{s2} den {s1}'ye doğru azalarak devam edecek");
                for (int i = s2; s1 <= i; i--)
                {
                    Console.WriteLine(i);
                }
            }
            */

            //Soru : Marketteki her ürünün fiyatını tek tek girip her biri için %18 kdv li fiyatını ekrana yazdıran program

            /*
             * Tüm ürünlerin toplam fiyatını kdv dahil olarak ekrana yazdıran program
             */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ürünün fiyatını giriniz:");
                int urun = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Kdv miktarı: " + (urun * 18) / 100);
                int son = (urun * 18) / 100 + urun;
                Console.WriteLine($"Urunun KDV li fiyatı : {son}");


               // double kdvli = Convert.ToDouble(Console.ReadLine());

            }


        }
    }
}

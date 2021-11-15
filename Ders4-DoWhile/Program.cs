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
             *Örn: klavyeden alınan sayıları toplayıp ekrana yaz
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
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ürünün fiyatını giriniz:");
                int urun = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Kdv miktarı: " + (urun * 18) / 100);
                int son = (urun * 18) / 100 + urun;
                Console.WriteLine($"Urunun KDV li fiyatı : {son}");


                // double kdvli = Convert.ToDouble(Console.ReadLine());
            
              }*/


            ////////////////////////// odev //////////////////////////
            ///

            /*
           Console.Write("Enter a number or enter 'q' to quit : ");
           string value = Console.ReadLine();
           int negativeSum = 0;
           int positiveSum = 0;

           while (value != "q")
           {
                int intValue = Convert.ToInt32(value);
                if (intValue == 34 || intValue ==-34)
                {
                    value = Console.ReadLine();
                    continue;

                }
                else
                {
                    if (intValue < 0)
                    {
                        negativeSum += intValue;
                       
                    }
                    else if (intValue > 0)
                    {
                        positiveSum += intValue;
                       
                    }
                }

                value = Console.ReadLine();

            }
            Console.WriteLine("negatif:" + negativeSum);
            Console.WriteLine("positive:" + positiveSum);
            */

            // Odev 2
            /*
            Console.Write("Enter something or enter 'q' to quit : ");
            string value = Console.ReadLine();
            string sequence = "";

            while (value != "q")
            {
                sequence += value + "\n";
                value = Console.ReadLine();
            }
            Console.WriteLine(sequence);

            */
            // odev 3
            /*
            int sum = 0;
            for (int i = 1; i < 10; i++)
            {
                int ifactorial = 1;
                for (int j = 1; j < i; j++)
                {
                    ifactorial *= j;
                }
                Console.WriteLine($"{i} factorial :" + ifactorial);
                sum += ifactorial;
            }
            Console.WriteLine(sum);
            */

            // odev 1 for loop cözümü

            int negSum = 0;
            int posSum = 0;
            for (; ;)
            {
                Console.WriteLine("Enter a number");
                string value = Console.ReadLine();
                if (value.ToLower()=="q")
                {
                    Console.WriteLine("negatif:" + negSum);
                    Console.WriteLine("positive:" + posSum);
                    break;
                }else if(value == "34" || value == "-34")
                {
                    Console.WriteLine("You entered an unvalid number");
                    continue;
                }
                else
                {
                    int intNum = Convert.ToInt32(value);
                    if (intNum < 0)
                    {
                        negSum += intNum;

                    }
                    else if (intNum > 0)
                    {
                        posSum += intNum;

                    }
                }
            }

            
   

        }
    }
}

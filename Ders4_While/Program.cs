using System;

namespace Ders4_While {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // while kullanmı
            /*
            int prim = 3500;
            bool koşul = prim < 7200;
            while (koşul ==true)
            {
                Console.WriteLine("Emekliliğe daha var");
                prim += 360;
                koşul = prim < 7200;
            }
            */

            /*
            int prim = 3500;
           
            while (prim < 7200)
            {
                Console.WriteLine("Emekliliğe daha var");
                prim += 360;
               
            }*/

            //1-10 arasındaki
            /*
            byte sayi = 1;
            while (sayi<= 10 )
            {
                Console.WriteLine(sayi);
                sayi ++;
            }*/

            // Soru : 1'den klavyeden girilen sayıya kadar olan sayıları ekrana yazdıran programı yazdırınız
            /*
            int s1 = Convert.ToInt32(Console.ReadLine());
            byte sayac = 0;
            while (sayac <= s1)
            {
                Console.WriteLine(sayac);
                sayac++;
            }*/


            // Soru : Klavyeden girilen değer çık olmadıqı sürece ekrana yazılanları yazdıran programı yaz
            /*

            Console.WriteLine("Mesajınızı yazınız(çıkmak için ÇIK yazınız)");

            string yazi = Console.ReadLine();
            while(yazi.ToLower() != "ÇIK")
            {
                Console.WriteLine(yazi);

                Console.WriteLine("Mesajınızı yazınız(çıkmak için ÇIK yazınız)");
                yazi = Console.ReadLine();
            }

            Console.WriteLine("Program sonlandı");*/


            // Klavyeden girilen deger "q" olmadığı sürece alınan sayıları topyalayıp en son ekrana toplamı yazdır
            /*
            string deger = Console.ReadLine();
            int sum = 0;
            bool isParsable = Int32.TryParse(deger, out _);
            while (deger != "q")
            {
                if(isParsable == true)
                {
                    sum += int.Parse(deger);
                    
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız");
               
                  

                }
                Console.WriteLine("Yeni sayı girisi yapınız");
                deger = Console.ReadLine();
                isParsable = Int32.TryParse(deger, out _);



            }
            Console.WriteLine($"Toplam: {sum} ");
            */

            // Soru : Klavyeden girilen ifade "cık" değilse girilen sayıların karesini toplayıp  ekrana yazıran programı
            // Koşul: girilen sayı 5 ve 5'in katı ise de programdan çık
            /*
            Console.WriteLine("Yeni sayı girisi yapınız");
            string deger = Console.ReadLine();
            int sum = 0;
          
            bool check = false; // 5 in katı mı
            while (deger != "q" && !check == true)
            {

                int sayi = Convert.ToInt32(deger);
                if (sayi%5 ==0)
                {
                    check = true;
                     break; yazarakta döngüden çıkabilirdik
                }
                else
                {
                    sum = sayi * sayi;
                    Console.WriteLine("Yeni sayı girisi yapınız");
                    deger = Console.ReadLine();
                }
                
              
            }
            Console.WriteLine($"Karelerin toplamı: {sum} ");*/

            // Soru: 1-100 arasındaki sayıların tek mi çift mi olduğunu yazan program
            /*
            int count = 1;
            while (count<100)
            {
                if(count%2 == 0)
                {
                    Console.WriteLine($"{count} çift sayıdır");
                    
                }
                else
                {
                    Console.WriteLine($"{count} tek sayıdır");
                }
                count++;
            }*/



            // Soru : klavyeden girilen sayıya kadar olan sayıları yazdıran program sürekli sayı isteyecek
            // Koşullar : 5'İn katlarında "BOM" yazsın. 19'un katına gelince programdan çıkılsın
            /*bool check = true;
            Console.Write("Sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            while (check)
            {

                if (sayi % 5 == 0)
                {
                    Console.WriteLine("BOM");


                }
                else if (sayi % 19 == 0)
                {
                    break;
                }
                Console.Write("Sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());

            }
            */

            // break ve continue kavramları
            // 1-10 arasındaki sayıları ekrana yazdıran program
            // 7  geldiğinfe birşey yazdırmasın
            // 9 a geldiğinde programdan çıksın
            /*
            int i = 1;
            while (i<=10)
            {
                if (i==7)
                {
                    i++;
                    continue;
                }
                else if (i==9)

                {
                    break;
                }
                Console.WriteLine(i);
                i++;

            }*/

  
            

        

        }
    }
}

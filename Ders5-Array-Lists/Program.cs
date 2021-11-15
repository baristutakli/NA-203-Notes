using System;
using System.Linq;
namespace Ders5_Array_Lists {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            //  tip[] dizi ismi = new tip[];
            int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // index

            Console.WriteLine($"Rakamlar dizisinin ilk elemanı : {rakamlar[0]}");
            Console.WriteLine($"Rakamlar dizisinin ilk elemanı : {rakamlar[5]}");
            rakamlar[0] = 100;
            rakamlar.SetValue(100, 0);// yukarıdaki işlemi böyle de yapabiliriz.
            Console.WriteLine(rakamlar[0]);
            string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya" };
            Console.WriteLine(sehirler);// return type of array

            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            foreach (var sehir in sehirler)// şehirler dizisindeki her bir eleman için bunu yap
            {
                Console.WriteLine(sehir);
            }
            */


            // Kullanıcıdan alınan 10 adet isim bilgisinin bir diziye kaydedip daha sonra dizi elemanlarını ekrana yazdırma
            /* string[] isimler = new string[10];
             for (int i = 0; i < 10; i++)
             {
                 string isim = Console.ReadLine();
                 isimler[i] = isim;

             }
             for (int i = 0; i < isimler.Length; i++)
             {
                 Console.WriteLine(isimler[i]);
             }*/


            /*
             * 
            
            int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            int indis10 = Array.IndexOf(puanlar, 10);
            int nextindis10 = Array.IndexOf(puanlar, 10,1);
            //  Bu method bize ilk bulduğu 10un indisini verdiği için başlangıç konumunu değiştirdik. 
            Console.WriteLine(indis10);
            
            object[] karisikDizi = new object[10];
            karisikDizi[0] = 10;
            karisikDizi[1] = "Ayşe";
            karisikDizi[2] = 15.4f;*/


            // Array.Sort(puanlar) küçükten büyüpğe sıralar
            // Array.Reverse(puanlar) sıralamayı terse çevirir


            // 0-100 arasında rastgele 10 sayı üretip bir diziye atın ve son olarak diziyi ekrana yazdırın

            //Console.WriteLine(rastGele.Next(0,100));
            /*int[] arr = new int[10];
            Random rastGele;
            for (int i = 0; i < 10; i++)
            {
                rastGele = new Random();
                arr[i] =  rastGele.Next(0,100);
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            */


            /*
            int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            int adet10 =puanlar.Count(sayi=> sayi == 10 );
            // her bir elemanını sayı değişkenine al. Koşul olarak satı 110 a eşitse
            Console.WriteLine($"Dizide {adet10} tane 10 değeri var");


            //dizideki 10 değerlerinin index numaralarını ekrana yazdırın. For döngüsü ile indexlerini yazdır
            // bir yol daha var
            int startİndex = 0;
            for (int i = 1; i < 10; i++)
            {
                if (puanlar[i-1] == 10)
                {
                    Console.WriteLine(Array.IndexOf(puanlar, 10, startİndex));
                    startİndex += i;
                }
                
            }

            // ikinci yol
            int startİndex2 = 0;
            for (int i = 1; i < adet10; i++)
            {
                if (puanlar[i - 1] == 10)
                {
                    Console.WriteLine(Array.IndexOf(puanlar, 10, startİndex2));
                    startİndex2 += 1;
                }

            }


            int bulunamayan = Array.IndexOf(puanlar, 100);
            Console.WriteLine(bulunamayan);// -1 döndürür
            */


            int[] dizi1 = { 11, 20, 45, 55, 66, 48,20,30,40, };
            int[] dizi2  =  new int[9];
            dizi1.CopyTo(dizi2,0);

            // dizi1 in 3 elemanından sonra 5 elemanı kopyala
            // dizi2 ye 0. indisten itibaren copyalar
            Array.Copy(dizi1, 3, dizi2, 0, 5);



            ///////////////////////////
            ///çok boyutlu diziler////
            //////////////////////////
            /*
            int[,] matris = new int[5, 5];

            matris[0, 0] = 10;
            matris[0, 1] = 100;
            Console.WriteLine(matris[0, 0]);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matris[i, j] =  i+ j;
                }
            }

            */


            /*
             * 2 0 0 0 2
             * 1 0 0 0 1
             * 2 0 0 0 2
             * 1 0 0 0 1
             * 2 0 0 0 2
             */

            /*
             * int[,] matris2 = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i%2 ==0)
                    {
                        matris2[i, 0] = 2;
                        matris2[i, 4] = 2;
                    }
                    else
                    {
                        matris2[i, 0] = 1;
                        matris2[i, 4] = 1;
                    }
                }
            }*/


            /*
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i % 2 == 0 &&(j==0 || j==4))
                    {
                        matris2[i, j] = 2;
                       
                    }
                    else if (i % 2 == 1 && (j == 0 || j == 4))
                    {
                        matris2[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matris2[i, j]+" ");
                }
                Console.Write("\n");
            }*/


            /*
           * 1 0 0 0 1
           * 0 1 0 1 0
           * 0 0 1 0 0
           * 0 1 0 1 0
           * 1 0 0 0 1
           
           int[,] matris = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i==j)
                    {
                        matris[i, j] = 1;
                    }
                    else if (i+j ==4)
                    {
                        matris[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matris[i, j] + " ");
                }
                Console.Write("\n");
            }
            */

            // 2x4'luk bir dizi tanımlayın
            // Bu dizinin her bir hücresi için klavyeden sayı alıp atayın
            // bu sayıyı ekrana yaz

            //her satırın son değeri hariç klavyeden alınsın
            // son kolon satırdaki sayıların toplamını tutsun
            /*
            int[,] matrix = new int[2, 4];
            for (int i = 0; i < 2; i++)
            {
                int sum = 0;
                for (int j = 0; j < 4; j++)
                {
                   


                    if (j!=3)
                    {
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                        sum += matrix[i, j];
                    }
                    else
                    {
                        matrix[i, j] = sum;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }

            */


            // 3D
            int[,,] matrix = new int[2,3,3];
            Random rmd = new Random();
            for (int i = 0; i < 2; i++)// 3x3 lük diziler
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        matrix[i, j, k] = rmd.Next(1000);
                        Console.Write(matrix[i, j, k] + "");
                    }
                    Console.WriteLine();

                }
                Console.WriteLine("***********");




            }
        }
    }
}

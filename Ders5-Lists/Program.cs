using System;
using System.Collections.Generic;
using System.Linq;

namespace Ders5_Lists {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] deneme = new int[10];
            // generic öğe oluşturma
            // Tanımlama
            List<int> ilkListem = new List<int>();
            List<string> sehirler = new List<string>()
            {
                "istanbul","Ankara", "İzmir", "Aksaray"
            };
            List<int> araList = new List<int>() { 500, 2000, 3000 };

            // Veri ekleme
            ilkListem.Add(1990);
            ilkListem.Add(1);
            ilkListem.Add(1920);
            ilkListem.Add(1920);
            ilkListem.Insert(0, 1200); 
            ilkListem.InsertRange(1, araList);


            //Veriye ulaşma
            //Console.WriteLine(sehirler[2]);
            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            foreach (var num in araList)
            {
                Console.WriteLine(num);
            }
            //Temizleme
            //ilkListem.Clear();


            // listenin x elemanın sayısını bulma
            int size = ilkListem.Count;
           // Console.WriteLine($"toplam eleman sayısı: {size}");


            // Listede var mı
            bool numCheck = ilkListem.Contains(123);
            //Console.WriteLine(numCheck);
            
            if (numCheck == false)
            {
                ilkListem.Insert(2, 123);
            }


            //Listeden silme
            ilkListem.Remove(123);
            ilkListem.RemoveAt(1);// 1. indexteki numarayı siler


            // ilkListem.TrueForAll(value => value == 10);
            // Console.WriteLine(ilkListem.TrueForAll(value => value == 10));
             Console.WriteLine(sehirler.BinarySearch("İzmir"));
            

            Console.WriteLine("-------------------------------------");
            /*
            // soru
            List<int> arr1 = new List<int>();
            List<int> arr2 = new List<int>();
            List<int> diff = new List<int>();
            Random rdm1;
            Random rdm2;
            for (int i = 0; i < 5; i++)
            {
             
                rdm1 = new Random();
                rdm2 = new Random();
                arr1.Add( rdm1.Next(1, 10));
                arr2.Add(rdm2.Next(1, 10));
                
            }
            
            foreach (var item in arr1)
            {
                if (!arr2.Contains(item))
                {
                    diff.Add(item);
                }
            }
            foreach (var item in arr2)
            {
                if (!arr1.Contains(item))
                {
                    diff.Add(item);
                }
            }

            foreach (var item in diff)
            {
                Console.WriteLine(item);
            }
            */
            // 1-100 arasında 15 sayı üretip bir listeye atın

            List<int> randomList = new List<int>();
            // Kullanıcıdan bir tahmin alıp, listede olup olmadığına bakın.
            // listede var ise index numarasını ekrana yaz
            /*
             Random rdm;
             for (int i = 0; i < 15; i++)
             {
                 rdm = new Random();
                 randomList.Add(rdm.Next(1, 100));
             }
             foreach (var item in randomList)
             {
                 Console.Write(item + " ");
             }

             int guess = Convert.ToInt32(Console.ReadLine());
             if (randomList.Contains(guess))
             {
                 Console.WriteLine(randomList.IndexOf(guess));
             }
            */

            // Soru: 0-255 arasında 1 sayı üretin
            // kullanıcıların 15 karakter alıp bir listeye atın
            // programın sonucunda kullanıcı karakteri bulursa, tebrik etsin ve karakteri ekranda gmstersin
            // Bulmazsa girdiği karakterler arasından üretilen karaktere en yakın olanı ve farkını yazın
            /*
            Random rnd = new Random();
            int rastGele = Convert.ToByte(rnd.Next(0,255));
            Console.WriteLine($"Üretilen : {rastGele}/{Convert.ToChar(rastGele)}");

            int enYakinTahmin = 255;

            List<int> tahminler = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Tahmin:");
                string k = Console.ReadLine();
                Console.Write(k + " : ");
                int kInt = Convert.ToInt32(k[0]); 
                tahminler.Add(kInt);
                Console.WriteLine(kInt);
            }

            foreach (var tahmin in tahminler)
            {
                if(tahmin==rastGele)
                {
                    Console.WriteLine("Tebrikler Buldunuz !");
                    char cTahmin = Convert.ToChar(tahmin);
                    enYakinTahmin = 0;
                    break;

                }
                else
                {
                    int fark = Math.Abs((rastGele - tahmin)); // Mutlak değer aldık.
                    if (fark < enYakinTahmin)
                        enYakinTahmin = (byte)fark;
                }
            }
            if(enYakinTahmin!=0)
                Console.WriteLine($"Malesef bulamadınız!\n Rastgele karakter/ ASCII kodu : {Convert.ToChar(rastGele)} /{rastGele} En yakın tahmininiz : {Convert.ToChar(enYakinTahmin)}/{enYakinTahmin} ");


            */
        }
    }
}

using System;

namespace Ders3_if_else {
    class Program {
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
            Console.WriteLine($"Toplam : {sum}");
        }
    }
}

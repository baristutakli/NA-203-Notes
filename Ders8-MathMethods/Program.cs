using System;

namespace Ders8_MathMethods {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            Bazı Math metodları
            int mutlak7 = Math.Abs(-7);
            double cos45 = Math.Cos(45);
            int max = Math.Max(5, 7);
            double powOf = Math.Pow(2, 5);
            double sqrt = Math.Sqrt(25);
            double logOf = Math.Log10(5);


            String methods


            Concat()
            string birlesim = String.Concat("Network", "Akademi", "203Sabah", 2021);
            Console.WriteLine(birlesim);
            string  str1 = "KADIKOY";
            string  str2 = "kadikoy";


            Compare()
            Console.WriteLine(String.Compare(str1, str2));
            Console.WriteLine(String.Compare(str1,1, str2,1,3));


            IndexOf()
            string mtn = "BEŞİKTAŞ";
            Console.WriteLine(mtn.IndexOf("Ş"));


            startsWith()
            Console.WriteLine(mtn.StartsWith("BEŞ"));


            EnsWith()
            Console.WriteLine(mtn.EndsWith("AŞ"));


            TRim
            string yazi = " FENERBAHÇE ";
            yazi.Trim(); // remove space at the start and the end

            char[] dizi = { 'A', 'H', 'Ç', 'E' };
            yazi = yazi.Trim(dizi);
            Console.WriteLine(yazi);


            PadLeft && PadRight
            string str3 = "MERHABA DUNYA";
            Console.WriteLine(str3.PadLeft(15, 'E'));

            Console.WriteLine(str3.PadRight(15, 'E'));


            split
            string cumle = "Merhaba arkadaşlar. Bugun sınav var";
            string[] kelimeler = cumle.Split(" ");
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }


            dizi halindeki verileri birleştirmek için join.
            string yeniCumle = String.Join(" ",kelimeler);
            Console.WriteLine(yeniCumle);


            toUpper toLower
            string youtubeStr = "https://www.youtube.com/watch?v=UP2XoGfhJ1Y";
            string[] adress = youtubeStr.Split("=");

            Remove
            string buyuk = "aaaaaaaaaaaaaavvvvvvvvvsdddddddddd";
            buyuk.Remove(0);
            buyuk.Remove(1, 2);

            insert
            buyuk.Insert(4, "------");



            Soru: girilen metindeki kelime sayısını bulan metodu yazınız
            Console.WriteLine("Kelime adedi : "+ WordCounter("Merhaba bugun hava soguk olacak mı"));

            Soru3: Girilen metni tersten yazan programı metot kulanarak yazınız

            Console.WriteLine(TersineCEvir("MERHABA"));
            */

      

        }


        

        static int WordCounter(string kelime)
        {
            string[] arr = kelime.Split(" ");
            return arr.Length;
        }

        static string TersineCEvir(string kelime)
        {
            string ters = "";
            for (int i = kelime.Length-1; i>=0  ; i--)
            {
                ters += kelime[i];
            }
            return ters;
        }

    }
}

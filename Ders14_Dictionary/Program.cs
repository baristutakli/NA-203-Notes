using System;
using System.Collections.Generic;

namespace Ders14_Dictionary {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<string, string> sozluk = new Dictionary<string, string>();

            // ekleme
            sozluk.Add("Red", "Kırmızı");
            sozluk.Add("White", "Beyaz");

            // Değiştirme

            sozluk["White"] = "beyaz";

            // Silme
            sozluk.Remove("White");

            // Arama 
            // sozluk.ContainsKey("Red");
            Console.WriteLine("White var mı:" + sozluk.ContainsKey("Red"));


            Dictionary<string, string> cities = new Dictionary<string, string>() {
                {"Turkiye","İstanbul, Konya, Sivas" },
                {"UK","London, Manchester, Washington" },
                {"India","Mumbai, Delphi, Pune" },
                {"USA","Chicago, New York, Washington" },
            };
            foreach (var item in cities)
            {
                Console.WriteLine(item.Key+" "+ item.Value);
            }

            

           // Generic

            



        }
       

   
    }
}

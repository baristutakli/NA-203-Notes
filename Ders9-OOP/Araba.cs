using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_OOP {
    class Araba {
        static int Id = 0;
        public string Marka;
        public string Model;

        public Araba()
        {
            Id += 1;
            Console.WriteLine(Id);
        }
        public void BilgiYaz()
        {
            Console.WriteLine($"Marka : {this.Marka}"); // this anahtar kelimesi nesneyi temsil eder.
            Console.WriteLine("Model" + Model);
        }


        // Yıkıcı method
        // Destructors in C# are methods inside the class used to destroy instances of that class 
        ~Araba()
        {
            // Veritabanı bağlantısı kontrolü: veritabanına kaydedilmişse kaydet silmeden 
            //sql
            Console.WriteLine("Deconstuctor çalıştı");

        }

    }
}

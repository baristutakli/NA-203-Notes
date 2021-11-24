using System;

namespace Abstraction {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // bir metodu abstract olrak tanımladıysan gövde tanımlayamazsın
            // gövde kısmı alt sınıflarında olacak
            // abstarct metodu tanımladıysan sınıfı da metodu tanımlaman gerekir
            // Miras alınacak sınıflarda bu isimde bir metod tanımlanmalıdır.
            // Üst sınıfın amacı alt sınıfa bir şablon üretmek oldu
            // Abstract sınıflardan nesne türetilemez
            // abstract sınıflarda abstract olmayan metot ve özellikler barındırılabilir
            // Abstract sınıflarda abstract olarak tanımlanan metotların gövdesi olmaz
            // Abstract olrak belirtilmiş metodlar alt sınıflardan tanımlanmak zorundadır.
            // Abstract'ın amacaı bir temel yapı oluşturmak



        }
    }
}

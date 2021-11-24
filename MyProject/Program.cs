using System;

namespace MyProject {
    class Program {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Room room1 = new Room(5,"Bob",1000);
            Room room2 = new Room(8, "Jack", 1500);
            Room room3 = new Room(10, "Elon", 2000);

            Console.WriteLine(room1.ToString());
            Console.WriteLine(room2.ToString());
            Console.WriteLine(room3.ToString());
            Console.WriteLine($"Total number of rooms: {room1.getTheTotalNumberOfRooms()} ");
            */


            /*
            Emlak sitesi:

            Sınıflar: Ilan,Kullanici
            Kullanici: ID,adSoyad,adres,telefon(kullaniciDuzenleme, BilgiYaz)
            Ilan: ID, tarih,baslik,aciklama,,satilikMiKiralikMi, fiyat, kullanici(ilanDuzenleme, BilgiYaz)

            Yukarıdaki sınıf ve metotları tanımlayınız.parantez içindekiler metotlar.*/
            User user1 = new User("Barış", "Manço", "4440444");
            Console.WriteLine(user1.ToString());
            user1.SellProduct("Gitar", "Klasik gitar", "Kiralık", 1000);
            Console.WriteLine(user1.ToString());
            user1.SellProduct("Ayakkabı", "Eskitilmiş ayakkabı ", "Satılık", 2000);
            Console.WriteLine(user1.ToString());



        }

    }
}

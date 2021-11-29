namespace MyProject {
    using System;

    internal class Program {
        internal static void Main(string[] args)
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
            /*
            User user1 = new User("Barış", "Manço", "4440444");
            Console.WriteLine(user1.ToString());
            user1.SellProduct("Gitar", "Klasik gitar", "Kiralık", 1000);
            Console.WriteLine(user1.ToString());
            user1.SellProduct("Ayakkabı", "Eskitilmiş ayakkabı ", "Satılık", 2000);
            Console.WriteLine(user1.ToString());
            */

            /*
            Person person = new Person("Bob","Marley","bobmarley@hotmail.com");
            Worker worker = new Worker("Dennis","Ka","deniska@hotmail.com","Cleaning");
            Manager manager = new Manager("Steve", "Jobs", "stevejobs@hotmail.com",new List<string>{ "It","HR"} );

            person.WhoAmI();
            worker.WhoAmI();
            manager.WhoAmI();*/

            Otomobil otomobil = new Otomobil(5);
            Kamyon kamyon = new Kamyon(6);
            kamyon.KornaCal();
            otomobil.KornaCal();
            kamyon.SagaDon();
            kamyon.SagaDon();
            otomobil.SagaDon();
            otomobil.SolaDon();
        }
    }

    public interface Tekerlek {
        void SagaDon();

        void SolaDon();
    }

    internal class Otomobil : Arac {
        public Otomobil(int yas) : base(yas)
        {
        }

        public override void KornaCal()
        {
            Console.WriteLine("Biiiip  biiip");
        }

        public override void SagaDon()
        {
            throw new NotImplementedException();
        }

        public override void SolaDon()
        {
            throw new NotImplementedException();
        }
    }

    internal class Kamyon : Arac {
        public Kamyon(int yas) : base(yas)
        {
        }

        public override void KornaCal()
        {
            Console.WriteLine("Bab bri bap bap bri bap bap Bap bap");
        }

        public override void SagaDon()
        {
            throw new NotImplementedException();
        }

        public override void SolaDon()
        {
            throw new NotImplementedException();
        }
    }

    internal abstract class Arac {
        protected Arac(int yas)
        {
            Yas = yas;
        }

        protected int Yas { get; set; }

        public void Fren()
        {
            Console.WriteLine("Fren yaptı");
        }

        public abstract void KornaCal();

        public abstract void SagaDon();

        public abstract void SolaDon();
    }
}

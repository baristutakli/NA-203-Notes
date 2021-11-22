using System;
using System.Collections.Generic;

namespace Ders9_OOP {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // constructor public olmalıdır

            Araba arabaNesnesi = new Araba();
            arabaNesnesi.Marka = "Mazda";
            arabaNesnesi.Model = "6";

            Araba arabaNesnesi2 = new Araba();
            arabaNesnesi2.Marka = "Honda";
            arabaNesnesi2.Model = "5";
            arabaNesnesi.BilgiYaz();
            arabaNesnesi2.BilgiYaz();
            // this kullanmadığında eğer girile parametre ile nesnenin özellikleri aynı isimde olursa sorun çıkar tanımaz



            // Yeni bir sınıf örneği
            // Öğrenci sınıfını aşağıdaki özellik ve metotları ile tanımlayınız.
            // Properties : tc, okulN,ad, soyad, sınıfÖğretnmeni
            // Methods :sınıfOğretmeniDegistir(string ogrtm
            // Methods: BilgiYaz() öğrencinin tüm bilgilerini ekrana yazdır

            // Öğrenciler
            Ogretmen ogrt = new Ogretmen("Mehmet Demir");
            Ogretmen ogrt2 = new Ogretmen("Ahmet Bilkent");
            Ogrenci Ogrenci1 = new Ogrenci("1111111", 12, "BarışT", ogrt);
            Ogrenci Ogrenci2 = new Ogrenci("1111112", 12, "asdasdas asdasd", ogrt);


            Ogrenci1.BilgiYaz();
            Ogrenci2.BilgiYaz();

            Ogrenci1.SınıfOgretmeniDegistir(ogrt);
            ogrt.ogrenciler.Add(Ogrenci1);
            Ogrenci2.SınıfOgretmeniDegistir(ogrt2);
            ogrt2.ogrenciler.Add(Ogrenci2);
            Console.WriteLine();
            Console.WriteLine();
            Ogrenci1.BilgiYaz();
            Ogrenci2.BilgiYaz();

            ogrt.OgrencileriYaz();
            ogrt2.OgrencileriYaz();



            // Derslik isimli sınıfı aşağıdaki özellik ve metotlar ile tanımlayınız
            // Bu senaryoda bir öğretmenin bir sınıfı var. Bir öğretmen bir derslikte ders işler

            // properties: derslikN, Adi, kapasite, kat
            // DerslikAtamaKontrol metodu olacak (ogretmen) -> öğretmenin öğrenci sayısı sınıf kapasitesinesııyorsa true yoksa false
            // DerslikAta(oğretmen) -> öğretmenin dersliği değiştiriliyor

            Derslik derslik1 = new Derslik(1, "mat", 20, 2);
            Derslik derslik2 = new Derslik(2, "fizik", 14, 1);


            derslik1.DerslikKontrol(ogrt);
            derslik1.DerslikAta(ogrt);

            derslik2.DerslikKontrol(ogrt2);
            derslik2.DerslikAta(ogrt2);

            derslik1.Yaz();
            derslik2.Yaz();




        }

    }







}

using System;
using System.Collections.Generic;
using System.Linq;
namespace Ders7_MetotSoruları {
    class Program {

        static List<object> personelList = new List<object>();
        
 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
            //Kullanıcıdan 2 sayı 1 işlem alıp sonucu döndüren metodu tanımlayınız
            Console.WriteLine("Hesaplama yapabilmek için iki sayı ve bir işlem belirtmeniz gerekir\n yapabileceğiniz işlemler aşağıda sıralanmıştır\n" +
                "Toplama için + giriniz\n" +
                "Çıkarma için - giriniz\n" +
                "Bolme için / giriniz\n" +
                "Çarpma için * giriniz\n" +
                "Us almak için önce ** giriniz (taban ,üs, işlem): ");
            Console.WriteLine(Hesapla(2, 2, "+"));
            Console.WriteLine("-"+ Hesapla(2, 2, "-")+ " -*-"+ Hesapla(2, 2, "*") +"-/- " + Hesapla(2, 2, "/")+" -**-"+ Hesapla(2, 2, "**"));

            // Make it double[]
            float[] fDizi = new float[5] { 10.5f, 20.4f, 25.8f, 22f, 88f };
            double[] dDizi = MakeItDouble(fDizi);
            foreach (var item in dDizi)
            {
                Console.WriteLine(item);
            }
            */


            
            // Personel bilgi sistemi yapıyoruz
            // TC(long) , AdSoyad, Adres Telefon için bir veya birer tane liste tanımlayabilirsiniz
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("Yeni kullanıcılar sisteme ekleniyor...");
            PersonelEkle(1235544, "asdasdas", "aaa21231aaa", "55555555");
            PersonelEkle(1235552, "asdas", "aaaa123a", "55555555");
            Console.WriteLine($"Sisteme eklendi mi: {PersonelEkle(1235242, "AAAAAAas", "aAAAA12aa", "15555555")}");
            Console.WriteLine();
            Console.WriteLine("Siliniyor...");
            PersonelSil(1235544);
            Console.WriteLine();
            Console.WriteLine("Kullanıcı bilgileri güncelleniyor...");
            Console.WriteLine(PersonelGüncelle(1235242, "asnnnndas", "aaaa12aa", "55555555"));
            Console.WriteLine("Kullanıcı bilgileri aranıyor...");
            Console.WriteLine("Arama sonucu: "+ AramaYap(1235552));

            Console.WriteLine(personelList.Count);

            Console.WriteLine("Odev tamamlandı!");
            



            // Sabit parametre dışında sayısız metod göndereceğimiz bir metot da var
            // Buna biz params anahtar kelimesini kullanarak birden fazla değer alabileceğimizi belirtiyoruz
            Console.WriteLine("Toplam :"+Topla(1, 2, 3));
            Console.WriteLine("Toplam :" + Topla(1, 2, 3,0,44,77));
            
            Console.WriteLine("Toplam :" + Topla(1, 2, 34,44,55,75));
            Console.WriteLine(PuanTopla("baris",24,100,80,60,70,80));



            // Faktoriyel fonksiyonunu recursion kullanarak yaptık
            Console.WriteLine("5 faktoriel = "+Faktorial(5));

            string t = " asdfgh";
            string t2 = t;
            t = "12354";
            Console.WriteLine(t + "  -"+ t2);


            //değer tipinde olduğu için s değişmedi ama referansını verirsek referansın olduğu yere gidip değeri değiştiriyor
            // ref kullanılırken parametrenin ilk değeri ataması zorunludur
            int s = 5;
            Console.WriteLine(DegerDegistir(ref s));
            Console.WriteLine(s);


            // out nedir bak 
            // out ta ilk değer atamak zorunlu değildir
            // Değişkenimiz ilk değer almazsa bunu kullanabiliriz
            int s2 = 2;
            Console.WriteLine(DegerDegistirOut(out s2));

            //out
            
        }

 

        static int DegerDegistir(ref int s1)
        {
            s1 = s1 * 10;
            return s1;
        }

        static int DegerDegistirOut(out int s1)
        {
            s1 = 20;
            return s1+100;
        }


        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        // params parametresini sabit parametrelerden sonra kullanıyoruz
        static string PuanTopla(string isim, int yas, params int[] puanlar)
        {
            int toplam = 0;
            foreach (var puan in puanlar)
            {
                toplam += puan;
            }
            return isim +" "+ "yas:"+ yas + "Toplam puan : "+toplam;
        }


        // Recrusive kendini tekrar eden veya çağıran metotlar

        static int Faktorial(int sayi)
        {
            if (sayi<=1)
            {
                return 1;
            }
            else
            {
                return sayi * Faktorial(sayi - 1);
            }
        }
      

        // Kullanıcıdan 2 sayı 1 işlem alıp sonucu döndüren metodu tanımlayınız
        static int Hesapla(int s1,int s2,string islem)
        {
            int result = 0;
            switch (islem)
            {
                case "+":
                    result = s1 + s2;
                    break;
                    
                case "-":
                   result = s1 - s2;
                   break;

                case "+*":
                    result = s1 * s2;
                    break;
                    

                case "/":
                    result = s2 / s2;
                    break;
                case "**":
                    result = (int)Math.Pow(s1, s2);
                    break;

            }
            return result;

        }



        // Kendisine gönderilen float dizisini double dizisine çeviren MakeItDouble fonks
        static double[] MakeItDouble(float[] fDizi)
        {
            
            double[] dDizi = new double[fDizi.Length];
            for (int i = 0; i < fDizi.Length; i++)
            {
                dDizi[i] = Convert.ToDouble(fDizi[i]);
            }
            return dDizi;
        }


        static bool PersonelEkle(long TC,string adSoyad, string adress, string telefon )
        {
            
            if (TC !=0 && adSoyad != "" && adress != "" && telefon != "")
            {
                personelList.Add(new List<object>() {TC,adSoyad,adress,telefon });

                return true;
            }
            else
            {
                return false;
            }


        }

        // Personelsil tc alacak eşleşen elemanı silecek
        static void PersonelSil(long Tc)
        {
            List<object> nl = new List<object>();
            foreach (List<object> item in personelList)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (item[i].Equals(Tc))
                    {
                        nl = item;
                        
                        
                        
                    }
                    
                }
            }
            Console.WriteLine($"{nl[0]} numaralı kişinin bilgileri silindi");
            personelList.Remove(nl);
          
        }

        static string PersonelGüncelle(long tc, string adSoyad = "", string  adress = "", string tel = "")
        {

            string degisenBilgiler = "";
          
            foreach (List<object> item in personelList)
            {

                if (item.Contains(tc))
                {

                    degisenBilgiler += $"{tc} numarasına ait Eski bilgiler :\n   adSoyad: {item[1]} - adress: {item[2]} -Tel: {item[3]}\n";

                    if (adSoyad != "" && adress != "" && tel != "")
                    {
                        item[1] = adSoyad;
                        item[2] = adress;
                        item[3] = tel;
                        
                    }
                    else if (!tel.Equals(""))
                    {
                        item[3] = tel;
                    }
                    else if (!adSoyad.Equals(""))
                    {
                        item[1] = adSoyad;
                    }
                    else if (!adress.Equals(""))
                    {
                        item[2] = adress;
                    }
                    degisenBilgiler += $"{tc} numarasına ait yeni bilgiler:\n   adSoyad: {item[1]} - adress: {item[2]} -Tel: {item[3]}";
                    


                }
            }
        
            return degisenBilgiler;
        }


        static string AramaYap(long tc=0L, string adSoyad = "", string adress = "", string tel = "")
        {
            string personel = "";
            foreach (List<object> item in personelList)
            {
                
                if (item.Contains(tc))
                {
                    personel += item[0] + "  " + item[1] + "  " + item[2] + "  " + item[3];

                }
                else if (item.Contains(adSoyad))
                {
                    personel += item[0] + "  " + item[1] + "  " + item[2] + "  " + item[3];
                }
                else if (item.Contains(adress))
                {
                    personel += item[0] + "  " + item[1] + "  " + item[2] + "  " + item[3];
                }
                else if (item.Contains(tel))
                {
                    personel += item[0] + "  " + item[1] + "  " + item[2] + "  " + item[3];
                }
            }
            return personel;

        }



    // Personel bilgi sistemi yapıyoruz
    // id, TC(long) , AdSoyad, Adres Telefon için bir veya birer tane liste tanımlayabilirsiniz
    // Personel ekle gerekliparametreleri alıp ekleme yapacak, başarılı olarak ekleyince true döndürecek
    // Personel sil Tc parametre olarak alınacak
    // Güncelleme personelGüncelle(tc hariç tüm bilgikeri opsiyonel olarak alıp güncelleme yapacak
    // herhangi bir parametre ile arama yap
    // parametreleri optionel yapmak için varsayılan değer atayabilirsin
    //PErsonlin eski ve yeni bilgisi string ile alt alta birleştirerek döndürülsün
    //personelin tüm bilgilerini string olarak döndürsün
        /*
    static void Topla(int s1=10,int s2=20)
        {

        }
        */


        
    

    }
}

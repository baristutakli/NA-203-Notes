using System;

namespace typeconversions {
    class Program {
        static void Main(string[] args)
        {
            byte byteSayi = 58;
            int intSayi = byteSayi;

            short shortSayi = 34;
            float floatSayi = 29.45f;
            double doubleSayi = floatSayi;

            //Console.Write(doubleSayi);

            int intSayi2 = 254;
            byte byteSayi2 = (byte)intSayi2;
           // Console.WriteLine(byteSayi2);


            // casting yaptığında veri kaybetme ihtimalin var onu unutma.
            // daha küçük bir aralığa geçeince kayıplar oluşuyor

            float fSayi = 77.345f;
            int iSayi = (int)fSayi;


            //////////////////////////////////////////////////
            // convert sınıfı metotları ile tür dönüşümü//////
            //////////////////////////////////////////////

            double dSayi = 678.456d;
            string sSayi = Convert.ToString(dSayi);

            string postaKodu = "34460";
            int postaKoduInt = Convert.ToInt32(postaKodu);
            // Console.WriteLine($"posta kodu tipş {postaKodu.GetType()}");

            int s1 = 10;
            int s2 = 15;
            int toplam = s1 + s2;

            // Soru: klavyeden girilen iki sayıyı toplayan program
/*
            Console.Write("Birinci sayıyı giriniz:");
            string sayi3 = Console.ReadLine();
            Console.Write("İkinci sayıyı giriniz:");
            string sayi4 = Console.ReadLine();
            int sonuc = Convert.ToInt32(sayi3) + Convert.ToInt32(sayi4);
            Console.WriteLine($"Toplam: {sonuc}");
*/

            /* Soru: Klavyeden Fahrenayt olarak girilen sıcaklık bilgisini santigrat
             * cinsine çevirip aşağıdaki formatta ekrana yazdıran program*/

            //32 Fahrenayt => 0santigrat derecedir
            // c= (f-32)/1.8

            string sfah = Console.ReadLine();
            double dFah = Convert.ToDouble(sfah);
            
            double dsan = (dFah - 32) / 1.8;
            dFah = Math.Round(dFah, 2);

            Console.WriteLine("derece:" +dsan);
        }
    }
}

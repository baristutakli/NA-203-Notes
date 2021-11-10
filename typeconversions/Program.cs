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

            Console.Write(doubleSayi);

            int intSayi2 = 254;
            byte byteSayi2 = (byte)intSayi2;
            Console.WriteLine(byteSayi2);


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
            Console.WriteLine($"posta kodu tipş {postaKodu.GetType()}");

        }
    }
}

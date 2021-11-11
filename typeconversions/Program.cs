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

            /*
            string sfah = Console.ReadLine();
            double dFah = Convert.ToDouble(sfah);
            
            double dsan = (dFah - 32) / 1.8;
            dFah = Math.Round(dFah, 2);

            Console.WriteLine("derece:" +dsan);*/

                 /// //////////////////////////////
            ///  11/11/2021 ///////////////////
            //////////////////////////
            ///
            /*
            checked{
                int intNum = 256;
                byte byteNum = (byte)intNum;// takes 8 rightest bits 
                Console.writline($"byte number: {byteNum}");

                    unchecked{
                        int ıntNum2 = 256;
                        byte =byteNum = (byte)intNum2 // even we lose some bites, casting does not stop
                    }

                } 
            */

            //////////////////////////////////////
            ///  Type casting* with parse method //////
            ///  //////////////////////////////////
            ///  parse metodu stringifadeleri sayısal değere dönüştürür.
            /// 
            int degisken1 = int.Parse("365");
            double degisken2 = double.Parse("34");
            short degisken3 = short.Parse("4321");


            ////////////////////////
            /// Boxing & unboxing//////////
            /// //////////////////////
            
            // object veri tipi tüm tiplerin üst tipidir.
            //dolayısıyla sorunsuz dönüştürebilir
            // Kasıtsız boxing
            int limit = 120;
            object kutu = limit;

            // casting ile boxing
            object kutu2 = (object)limit;

            // unboxing
            // 1. kural: unboxing uygulancak nesne daha önceden boxing uygulanmış olmalıdır.
            // 2. kural: nesne içerisindeki değer hedef tipte olmalıdır

            float ondalikSayi = 94.5f;
            //boxing
            object nesne = ondalikSayi;
            // unboxing
            ondalikSayi = (float)nesne;
            //


            // Örnek: Klavyeden alınan iki sayının toplamını karesini ekrana yazdıran programı yazınız

            Console.Write("ilk sayıyı giriniz :");
            string num1 = Console.ReadLine();
            Console.Write("ilk sayıyı giriniz :");
            string num2 = Console.ReadLine();

            int result = (int.Parse(num1)+int.Parse(num2));
            int square = result*result;
            Console.WriteLine($"Sayıların kareleri toplamı: {square}");
        }
    }
}

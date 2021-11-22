using System;
using System.Collections.Generic;

namespace Ders8_TryCatchFinally {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Try catch sayesinde hata alma olasılığımız olan kod bloklarını çalıştırmadan önce sağlıklımı değilmi kontrol etmiş  oluruz
            // Hatasız ise try hata var ise catch blogu çalışır
            // Eğer eklersek finally bloğu her iki durumda da çalışır.
            /*

            int bolunen = 20;
            int bolen = 0;
            try
            {
                int bolum = bolunen / bolen;
            }
            catch (System.DivideByZeroException)
            {
                Console.Write("sıfıra bölünme hatası"+ " ama program durmadı");

            }
            finally //Her koşulda çalışır
            {
                Console.WriteLine("Try daki block çalışsa da çalışmasa da çalışan blog.");
            }
            */


            /*
            // Spesifik hata yakalama
            int bolunen = 20;
            int bolen = 0;
            try
            {
                int bolum = bolunen / bolen;
            }
            catch (DivideByZeroException hata)
            {
                Console.Write("sıfıra bölünme hatası : " + hata.Message);
            }
            catch (FormatException  hata)
            {
                Console.Write("Format hatası : " + hata.Message);
            }
            catch (Exception hata)
            {
                Console.Write("Format hatası : " + hata.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            */

        // Mulakat sorusu  Time complexity is o(n^3) space complexity o(n)
        string input = "nhoJ (Griffith) nodnoL saw (an) (American) ,tsilevon, tsilanruoj (and) laicos .tsivitca ((A) reenoip (of) laicremmoc noitcif (and) naciremA ,senizagam (he) saw eno (of) (the) tsrif (American) srohtua (to) emoceb (an) lanoitanretni ytirbelec (and) nrae a egral enutrof (from) ).gnitirw";
            
            
            
            input = input.Replace("((", "(");
            input = input.Replace(") )", ") ");
            string[] arr = input.Split(" ");

            List<string> strList = new List<string>();
            string nwStr = "";
            foreach (var item in arr)
            {
                if(!item.Contains("("))// parantez yoksa tersine çevir
                {
                    for (int j = item.Length - 1; j >= 0; j--)
                    {
                        nwStr += item[j];

                    }
                    
                    strList.Add(nwStr);
                    nwStr = "";

                }
                else // parantez varsa parantezleri kaldır
                {
                    
                    foreach (var i in item)
                    {
                        if (i != Convert.ToChar("(") && i != Convert.ToChar(")"))
                        {
                            nwStr += i;
                        }
                    }
                   
                    strList.Add(nwStr);
                    nwStr = "";
                }
            }
            Console.WriteLine();
            foreach (var nitem in strList)
            {
                Console.Write(nitem+" ");
            }
            Console.WriteLine();



      
            
        }








    }
}

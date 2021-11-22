using System;

namespace Ders8_DateTime {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            DateTime time = new DateTime();
            time = DateTime.Now;
            Console.WriteLine("Ay : " + time.Month);
            Console.WriteLine("Yıl : " + time.Year);
            Console.WriteLine("Tarih : " + time.ToShortDateString());
            Console.WriteLine("Gün : " + time.Day);

            Console.WriteLine("Haftanın Kaçıncı Günü : " + time.DayOfWeek);
            Console.WriteLine("Yılın Kaçıncı Günü : " + time.DayOfYear);
            Console.WriteLine("Günün Kaçıncı Saati : " + time.TimeOfDay);
            Console.WriteLine();
            Console.WriteLine("Saat : " + time.Hour);
            Console.WriteLine("Dakika : " + time.Minute);
            Console.WriteLine("Saniye : " + time.Second);
            Console.WriteLine("Milisaniye : " + time.Millisecond);
            Console.WriteLine("Başlangıç tarihinden tutulan tarihe kadarki periyod sayısı : " + time.Ticks);

            /*
             * TimeSpan: İki tarih arasıdaki süreyi tutan tiptir.
             */

            DateTime mddg = new DateTime(1988, 5, 5);
            DateTime bugun = DateTime.Now;

            TimeSpan gecenZaman = bugun - mddg;

            Console.WriteLine(gecenZaman.Days + " Gün");
            Console.WriteLine(mddg.DayOfWeek + " Doğduğunuz Gün");
        }
    }
}

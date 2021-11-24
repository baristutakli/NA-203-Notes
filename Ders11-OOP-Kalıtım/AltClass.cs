using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım {
    class AltClass:AnaClass { //Kalıtım yolu ile miras aldık
        // Her sınıf tek bir sınıftan miras alabilir
        private string _AdSoyad;
        public string AdSoyad
        {
            get { return this._AdSoyad; }
            set { this._AdSoyad = value; }
        }


        public void adSoyadYaz()
        {
            Console.WriteLine($"Ad soyad: {this.AdSoyad}");
        }
        /// <summary>
        /// Override işlemi yapıyoruz. Bunu kasıtlı olarak yaptıysan new anahtarını  başa koy
        /// new public void BilgiYaz gibi
        /// </summary>
        new public void BilgiYaz()
        {
            // base.ıd dediğimizde ana class ın ıdsini getirecek
            base.BilgiYaz();// Anasınıfın metodunu çağırıyoruz. Ana sınıftaki metot çalıştıktan sonra  kendi kodumuz çalışır.
            Console.WriteLine($"ilan tarihi: {base.KayitTarihi}\n Ad Soyad: {this.AdSoyad}");
        }
    }
}

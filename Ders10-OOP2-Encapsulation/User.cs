using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP2_Encapsulation {
    class User {
        int Id;
        string adSoyad;
        private string _adress;
        private string _Tel; // Bu kullanım doğru olur
        public string Adress
        {
            get { return this._adress; }
            set
            {
                if (!string.IsNullOrEmpty(value) && (!String.IsNullOrWhiteSpace(value)))
                {
                    this._adress = value;
                }
            }
        }

        // Telefon özelliği sadece _ tel  özelliğine erişim için kullanılır. Bu şekilde direk verinin değişkeninin öğrenilmesi engellenir
        public string Tel { get { return this._Tel; } set { this._Tel = value; } }


        // Kontrollü erişim sağlamak için properties access identifier larını private yaptık.
        // public erişim belirteçleri heryerden değiştirilir
        // private sadece sınıf içinden değiştirilebilir
        // protected sadece sınıf içerisinden ve kalıtım yoluyla miras alan alt sınıflardan erişilebilir
        // internal sadece aynı assembly 


        public void AdSoyadDuzenle(string adSoyad)
        {
            if (!string.IsNullOrEmpty(adSoyad) && (!String.IsNullOrWhiteSpace(adSoyad)))
            {
                this.adSoyad = adSoyad;
            }
            else
            {
                Console.WriteLine("Boşluklardan oluşan veya tamamen bışluk olan bir ad yazamazsıznız");
            }
        }


        public string getAdSoyad()
        {
            return this.adSoyad;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_Kalıtım {
    class AnaClass {
        // Gerekli olan ne varsa tanımlayacağız
        
        private int _Id;
        public int ID
        {
            get { return this._Id; }
            /* set// id'yi otomatik ekleyim set kısmını disable edebiliriz.
             {
                 if (value<= int.MaxValue && value >=int.MinValue)
                 {
                     this._Id = value;
                 }

             }*/

        }
        private DateTime _KayitTarihi;
        public DateTime KayitTarihi
        {
            get { return this._KayitTarihi; }
            set
            {
                this._KayitTarihi = value;
            }
        }

        public void IlanTarihiYaz()
        {
            Console.WriteLine($"İlan Id: {this.ID}\nilan tarihi: {this.KayitTarihi}");
        }

        // Ana classta oluşturduğumuz bir metodu alt classta tekrar tanımlarsak ne olur
        public void BilgiYaz()
        {
            Console.WriteLine($"İlan Id: {this.ID}\nilan tarihi: {this.KayitTarihi}");
        }
    }
}

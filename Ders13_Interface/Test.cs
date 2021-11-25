using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface {
    class Test : ISablon, ISablon2 {
        public string Marka { get; set;  }
        public string Model { get; set; }
        public string ID { get; set; }
        public double Fiyat { get; set; }
        public Kategori Kategori { get; set; }

        public void BilgiYaz()
        {
            Console.WriteLine("Bilgi");
        }

        public double GetFiyat()
        {
            throw new NotImplementedException();
        }
    }
}

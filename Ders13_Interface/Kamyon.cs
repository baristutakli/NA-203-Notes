using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface {
    class Kamyon : Arac {
        public short _tasimaKapasitesi { get; set; }
        public override void KaskoYap()
        {
            Console.WriteLine("Kasko Yap");
        }

        public override void VergiHeapla()
        {
            Console.WriteLine("Vergi Hesapla");
        }
    }
}

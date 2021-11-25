using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface {
    abstract class Arac : IVasita, Ilan {
        public long IlanN { get; set ; }
        public DateTime IlanTarihi { get; set; }
        public Kullanici satici { get; set; }
        public string Marka { get; set; }
        public string Model { get; set ; }

        public Sigorta Sigorta { get; set; }
        public KasaTipi KasaTipi { get; set; }
        public void SigortaYap() {
            this.Sigorta = new Sigorta();
        }

        abstract public void VergiHeapla();

        abstract public void KaskoYap();

        

    }
}

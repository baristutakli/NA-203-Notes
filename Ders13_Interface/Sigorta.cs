using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface {
    class Sigorta {
        static int sigortaSayisi = 0;
        string _sigortaNumarası;
        DateTime _bitisTarihi;

        public Sigorta()
        {
            sigortaSayisi += 1;
            this._sigortaNumarası = DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + "_";
            if (10 > sigortaSayisi)
            {
                this._sigortaNumarası += "00" + sigortaSayisi;
            }else if (100>sigortaSayisi && sigortaSayisi>=10)
            {
                this._sigortaNumarası += "0" + sigortaSayisi;
            }
            _bitisTarihi = DateTime.Now.AddYears(1);
        }

        public string SigortaNumarası { get => _sigortaNumarası;}
        public DateTime BitisTarihi { get => _bitisTarihi; set => _bitisTarihi = value; }

        public void  SigortaYap(Otomobil arb)
        {
          
            arb.Sigorta.BitisTarihi= arb.Sigorta.BitisTarihi.AddYears(2);
           
        }

    }
}

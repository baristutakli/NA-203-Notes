using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction {
    class LokantaYozgat : Lokanta {

        public LokantaYozgat()
        {
            this._HarcMiktari = 1500.0D;
        }

        public override void HarcOde()
        {
            Console.WriteLine($"LokantaYozgat Sınıfı: Harç Miktarı : {this._HarcMiktari}");
        }

    }
}

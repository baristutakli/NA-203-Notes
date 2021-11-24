using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction {
    class LokantaTokat : Lokanta {
        public LokantaTokat()
        {
            this._HarcMiktari = 2000.0D;
        }

        public override void HarcOde()
        {
            Console.WriteLine($"LokantaTokat Sınıfı: Harç Miktarı : {this._HarcMiktari}");
        }
    }
}

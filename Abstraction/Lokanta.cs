using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction {
    abstract class Lokanta {
        protected double _HarcMiktari;

        public Lokanta()
        {
            this._HarcMiktari = 3000.0D;
        }

        abstract public void HarcOde();
     
    }
}

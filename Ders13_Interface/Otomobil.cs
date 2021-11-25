using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ders13_Interface {
    enum YakitTipi {
        Dizel, Motorim,LPG
    }
    enum VitesTipi {
        Manual, otomatik
    }

    enum KasaTipi {
        Kısa,orta,uzun
    }
    class Otomobil :Arac {
        YakitTipi _yakitTipi;
        VitesTipi _vitesTipi;
        KasaTipi _kasaTipi;
        float _motorHacmi;
        Sigorta _sigorta;

        public Otomobil(YakitTipi yakitTipi, VitesTipi vitesTipi, KasaTipi kasaTipi, float motorHacmi)
        {
            _yakitTipi = yakitTipi;
            _vitesTipi = vitesTipi;
            _kasaTipi = kasaTipi;
            _motorHacmi = motorHacmi;
        }

        

        public override void KaskoYap()
        {
            Console.WriteLine("Otomobil Kasko Yap");
        }

        public Sigorta SigortaYap()
        {
            this.Sigorta = new Sigorta();
            return this.Sigorta;
        }

        public override void VergiHeapla()
        {
            Console.WriteLine("Otomobil Kasko Yap");
        }
    }
}

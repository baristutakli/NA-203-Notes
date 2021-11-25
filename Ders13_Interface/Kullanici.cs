using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_Interface {
    class Kullanici {
        string _adSoyad;
        string _mail;
        string _tel;

        public Kullanici(string adSoyad, string mail, string tel)
        {
            _adSoyad = adSoyad;
            _mail = mail;
            _tel = tel;
        }

        public string AdSoyad { get => _adSoyad; set => _adSoyad = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string Tel { get => _tel; set => _tel = value; }

        public List<string> KullaniciBilgileri()
        {
            return new List<string>()
            {
                this.AdSoyad, this.Mail, this.Tel
        };
            
        }
    }
}

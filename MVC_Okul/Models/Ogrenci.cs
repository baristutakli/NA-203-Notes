using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Okul.Models
{
    public class Ogrenci
    {
        public  int Numara { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sinif { get; set; }

        private static int NSayac = 1;
        public Ogrenci()
        {
            NSayac += 1;
            this.Numara = NSayac;
            
        }
    }
}
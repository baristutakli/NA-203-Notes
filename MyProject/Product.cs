using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject {
    class Product {
        // Ilan: ID, tarih,baslik,aciklama,,satilikMiKiralikMi, fiyat, kullanici(ilanDuzenleme, BilgiYaz)
        static short count = 0; // is the number of products
        string publicationTime;
        string title;
        string details;
        string options;
        int price;

        public Product( string title, string details, string options, int price)
        {
            
            DateTime time = DateTime.Now;
            this.publicationTime = time.Day + "/" + time.Month + "/" + time.Year + " " + time.Hour + ":" + time.Minute;
            this.title = title;
            this.Details = details;
            this.Options = options;
            this.price = price;
            count += 1;
        }

       
        public string Options { get => options; set => options = value; }
        public int Price { get => price; set => price = value; }
        public string Title { get => title; set => title = value; }
        public string Details { get => details; set => details = value; }

        public override string ToString()
        {
            return $"Published at: {this.publicationTime}\nTitle:{Title}\nDetails: {Details}\nOption:{Options}\nPrice:{Price}\n";
        }
    }
}

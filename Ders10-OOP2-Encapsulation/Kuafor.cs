using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP2_Encapsulation {
    enum Hizmetler {
        Saç_Traşı,
        Sakal_Traşı,
        Saç_Yıkama,
        Cilt_Bakımı
    }
    class Kuafor {
        // enum: Hizmetler: Saç Traşı,Sakal Traşı, Saç Yıkama, Cilt Bakımı
        // Saç Tıraşı: 20, Sakal Traşı: 15, Saç Yıkama: 10, Cilt Bakımı
        // ID, Ad ,sacTırasiUcreti,sakalTrasiUcreti,SacYikamaUcreti,CiltBakimiUcreti
        // ToplamTutar.

        // Metotlar: SacTrasiYap(),SakalTrasiYap(),SacYika(),CiltBakimiYap()
        // BilgiYaz().
        float toplamUcret;
        float sacTirasiUcreti;
        float sakalTirasiUcreti;
        float sacYikamaUcreti;
        float ciltBakimiUcreti;
        string _musteri;

        List<Hizmetler> alinanHizmetler = new List<Hizmetler>();

        public Kuafor(string musteri)
        {
            this._musteri = musteri;
            this.toplamUcret = 0;
            this.sacTirasiUcreti = 20.0f;
            this.sakalTirasiUcreti = 15.0f;
            this.sacYikamaUcreti = 10.0f;
            this.ciltBakimiUcreti = 30.0f;
        }
        public void SacTrasiYap()
        {
            alinanHizmetler.Add(Hizmetler.Saç_Traşı);
            toplamUcret += this.sacTirasiUcreti;
        }
        public void SakalTrasiYap()
        {
            alinanHizmetler.Add(Hizmetler.Sakal_Traşı);
            toplamUcret += this.sakalTirasiUcreti;
        }
        public void SacYika()
        {
            alinanHizmetler.Add(Hizmetler.Saç_Yıkama);
            toplamUcret += this.sacYikamaUcreti;
        }
        public void CiltBakımıYap()
        {
            alinanHizmetler.Add(Hizmetler.Cilt_Bakımı);
            toplamUcret += this.ciltBakimiUcreti;
        }

        public void BilgiYaz()
        {
            foreach (var item in alinanHizmetler)
            {
                Console.Write(item +" ");
            }
            Console.Write("fiyat:"+toplamUcret);
        }

    }
}


using MVC_Okul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Okul.Controllers
{
    public class OgrenciController : Controller
    {
        // Veri tabanı yerine kullandık
        public static List<Ogrenci> Ogrenciler = new List<Ogrenci>() { new Ogrenci {Numara=1,FirstName="Barış",LastName="Tutakli" ,Sinif="NA203"} };
        // GET: Ogrenci
        // Öğrenci listesini yazdırsın. Yanlarında detay, Düzenleme, silme bağlantıalrı birlikte olsun

        private Ogrenci _Ogr { get; set; }

        public Ogrenci Ogr
        {
            get
            {
                if (this._Ogr==null)
                {
                    this._Ogr = new Ogrenci();
                   
                }
                return this._Ogr;
            }
            set
            {
                this._Ogr = value;
            }
        }
        public OgrenciController()
        {
            if (Ogrenciler.Count==0)
            {
                Ogrenciler.Add(Ogr);
            }
        }

        public ActionResult Index()
        {
            return View(Ogrenciler);
        }
        public ActionResult Ekle()
        {
            return View(Ogr);
        }

        [HttpPost]
        public ActionResult Ekle(Ogrenci ogrenci)
        {
            Ogrenciler.Add(ogrenci);
           return RedirectToAction("Index");
        }

        public ActionResult Sil(int ogrNo)
        {
            

            try
            {
                Ogrenci ogr = Ogrenciler.Find(Ogrenci => Ogrenci.Numara == ogrNo);
                Ogrenciler.Remove(ogr);
            }
            catch (Exception e)
            {
                throw e;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Detay(int ogrNo)
        {

            try
            {
                Ogrenci ogr = Ogrenciler.Find(Ogrenci => Ogrenci.Numara == ogrNo);
                return View(ogr);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public ActionResult Duzenle(int ogrNo,Ogrenci ogrenci)
        {
            try
            {
                Ogrenci ogr = Ogrenciler.Find(Ogrenci => Ogrenci.Numara ==ogrNo);
                ogr.FirstName = ogrenci.FirstName;
                ogr.LastName = ogrenci.LastName;
                ogr.Sinif = ogrenci.Sinif;
                return View(ogr);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
      


    }
}
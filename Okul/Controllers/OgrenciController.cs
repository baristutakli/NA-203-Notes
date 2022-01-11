using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Okul.Models;
using Okul.Tools;
namespace Okul.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Index()
        {
            // ViewBag.isimler = new List<string> { "Ahmet", "Ayşe", "Veli" };
            Ogrenci ogrenci = new Ogrenci { Id = 1, FistName = "Cem", LastName = "Yılmaz", Age = 45 };
            Ogretmen ogretmen = new Ogretmen { Id = 2, FistName = "Mehmet", LastName = "Demir" };
            OgrenciOgretmen birlesim = new OgrenciOgretmen { Ogrenci = ogrenci, Ogretmen = ogretmen };
            return View(birlesim);// model aracılığı ile controller dan view e nesne gönderdik
        }

        public ActionResult Kaydet()
        {
            //ViewData["isim"] = "Barış Tutakli";
            //ViewBag.Okul = "Network Academy";
            //TempData["ogretmen"] = "ogretmen";// İki action arasında veri transferi sağladık

            //return RedirectToAction("Index"); // veriyi kaydetten ındexe gönderik TempData daki veri aktarabildik
            

            return View();
        }
        
    }
}
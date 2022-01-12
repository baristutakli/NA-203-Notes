using Okul.DataAccess;
using Okul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Okul.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult Index()
        {
            IEnumerable<Ogrenci> listem = new List<Ogrenci> { new Ogrenci { Id = 1, FistName = "Cem", LastName = "Yılmaz", Age = 45 } };
            return View(listem);
        }

        // Get: Ogrenci create form
        public ActionResult Create()
        {
            Ogrenci ogrenci = new Ogrenci();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Ogrenci ogrenci)
        {
            int insertedId = OgrenciDal.Current.Create(ogrenci);
            TempData["insertedId"] = insertedId;
            return RedirectToAction("Index");
        }

        
    }
}
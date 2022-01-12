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
            IEnumerable<Ogrenci> listem = OgrenciDal.Current.GetStudents();
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
        public ActionResult Edit(int id)
        {
            Ogrenci ogrenci = OgrenciDal.Current.GetStudentById(id);
            return View(ogrenci); //Veritabanından gelen ogrenciyi view e gönderdik
        }

        [HttpPost]
        public ActionResult Edit(Ogrenci ogrenci)
        {
            if (OgrenciDal.Current.Update(ogrenci))
            {
                return RedirectToAction("Index");
            }
            else
            {
                
                return RedirectToAction("Edit", new { id = ogrenci.Id });
            }

            
        }
    }
}
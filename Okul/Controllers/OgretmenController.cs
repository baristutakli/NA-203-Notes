﻿using Okul.DataAccess;
using Okul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Okul.Controllers
{
    public class OgretmenController : Controller
    {
        // GET: Ogretmen
        private static Ogretmen _ogretmen {get;set;}
        public static Ogretmen ogretmen
        {
            get
            {
                if (_ogretmen == null)
                {
                    _ogretmen = new Ogretmen();

                }
                return _ogretmen;
            }
            set
            {
                _ogretmen = value;
            }
        }
        public ActionResult Index()
        {
            IEnumerable<Ogretmen> listem = OgretmenDal.Current.GetTeachers();
            return View(listem);
        }
        public ActionResult Create()
        {
            Ogretmen ogretmen = new Ogretmen();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Ogretmen ogretmen)
        {
            int insertedId = OgretmenDal.Current.Create(ogretmen);
            TempData["insertedId"] = insertedId;
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Ogretmen ogretmen = OgretmenDal.Current.GetTeacherById(id);
            return View(ogretmen); //Veritabanından gelen ogrenciyi view e gönderdik
        }

        [HttpPost]
        public ActionResult Edit(Ogretmen ogretmen)
        {
            if (OgretmenDal.Current.Update(ogretmen))
            {
                return RedirectToAction("Index");
            }
            else
            {

                return RedirectToAction("Edit", new { id = ogretmen.Id });
            }


        }

        public ActionResult Details(int id)
        {
            ogretmen = OgretmenDal.Current.GetTeacherById(id);
            return View(ogretmen);
        }

        public ActionResult Delete(int id)
        {
            ogretmen = OgretmenDal.Current.GetTeacherById(id);
            return View(ogretmen);
        }
        [HttpPost]
        public ActionResult Delete(Ogretmen ogretmen)
        {
            bool check = OgretmenDal.Current.Delete(ogretmen);
            if (check)
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData["hata"] = "Silme hatası";
                return RedirectToAction("Delete", new { id = ogretmen.Id });
            }
        }

        [HttpPost]
        public ActionResult Ara(string arananKelime)
        {
            var result = OgretmenDal.Current.Search(arananKelime);
            return View(result);
        }

    }
}
using Okul.DataAccess;
using System.IO;
using Okul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Okul.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci

        private static Ogrenci _ogrenci { get; set; }
        public static Ogrenci ogrenci
        {
            get
            {
                if (_ogrenci ==null)
                {
                    _ogrenci = new Ogrenci();
                   
                }
                return _ogrenci;
            }
            set
            {
                _ogrenci = value;
            }
        }
        public ActionResult Index()
        {
            IEnumerable<Ogrenci> listem = OgrenciDal.Current.GetStudents();
           
            return View(listem);
        }
        public ActionResult Login()
        {
            return View();
        }
        // role based auth
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            if (username=="admin" && password=="admin123")
            {
                FormsAuthentication.SetAuthCookie("admin", false);
                return RedirectToAction("Create");
            }
           return RedirectToAction("Login");
        }


        [Authorize]
        // Get: Ogrenci create form
        public ActionResult Create()
        {
            List<Ogretmen> teachers = OgretmenDal.Current.GetTeachers();
            ViewBag.teachers = teachers;
            Ogrenci ogr = new Ogrenci();
            return View(ogr);
        }
        [HttpPost]
        public ActionResult Create(Ogrenci ogrenci)
        {

            int insertedId =OgrenciDal.Current.Create(ogrenci);
            ogrenci.Id = insertedId;
            UploadPhoto(ogrenci);
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
                if (ogrenci.Photo!=null)
                {
                    UploadPhoto(ogrenci);
                }
                
                return RedirectToAction("Index");
            }
            else
            {
                
                return RedirectToAction("Edit", new { id = ogrenci.Id });
            }

            
        }

        public ActionResult Details(int id)
        {
            ogrenci = OgrenciDal.Current.GetStudentById(id);
            return View(ogrenci);
        }

        public ActionResult Delete(int id)
        {
            ogrenci = OgrenciDal.Current.GetStudentById(id);
            return View(ogrenci);
        }
        [HttpPost]
        public ActionResult Delete(Ogrenci ogrenci)
        {
           bool check= OgrenciDal.Current.Delete(ogrenci);
            if (check)
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData["hata"] = "Silme hatası";
                return RedirectToAction("Delete", new { id = ogrenci.Id });
            }
        }

        [HttpPost]
        public ActionResult Ara(string arananKelime)
        {
            var result = OgrenciDal.Current.Search(arananKelime);
            return View(result);
        }

        [NonAction] //bu metod controller actionı değil
        private void UploadPhoto(Ogrenci ogrenci)
        {
            string uploadedTime = DateTime.Now.ToString();
            string mainPath = Server.MapPath($"~/Assets/Student/{ogrenci.Id}/");

            if (!Directory.Exists(mainPath))
            {
                Directory.CreateDirectory(mainPath);
            }
            
            try
            {
                string path = Path.Combine(mainPath, Path.GetFileName(ogrenci.Photo.FileName));
                ogrenci.PhotoAdress = ogrenci.Id + "/" + ogrenci.Photo.FileName;
                ogrenci.Photo.SaveAs(path);
            }
            catch (Exception)
            {

                throw;
            }

              OgrenciDal.Current.Update(ogrenci);
        }
    }
}
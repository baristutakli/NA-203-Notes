using MVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC01.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        static List<string> categories = new List<string> { "Car", "House", "Mobil" };

        public ActionResult CarListem()
        {
            return View(categories); // model aracılığı ile veri taşıma
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category c)
        {
            categories.Add(c.CategoryName);
            return RedirectToAction("CarListem");
        }

    }
}
/*
 * Model: sınıflarımızın bulunduğu alan
 * View: Sayfalarımızın bulubduğu alan
 * Controller: Kullanıcı isteklerinin cevaplandırıldığı/yönlendirildiği alan
 * 
 * Route: Hangi URL hangi controller'daki hangi action'a yönlendirilecek.
 * 
 */
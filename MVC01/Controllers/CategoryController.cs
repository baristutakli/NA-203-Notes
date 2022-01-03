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

        List<string> categories = new List<string> { "Car", "House", "Mobil" };

        public ActionResult CarListem()
        {
            return View(categories); // model aracılığı ile veri taşıma
        }
    }
}
/*
 Product isimli controller tanımlayınız. Içerisinde aşağıdaki sayfaları çalıştıracak actionlar bulunsun
    Create => ProductName, UnitPrice bilgilerini action'dan almalı
     Delete => ProductID bilgisi action'dan alınsın
    Update => ProductID bilgisi action'dan alınsın
    Add => ProductName, UnitPrice bilgileri Action'dan alınsın
 */
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
            return View();
        }

        public ActionResult Kaydet()
        {
            return View();
        }
        
    }
}
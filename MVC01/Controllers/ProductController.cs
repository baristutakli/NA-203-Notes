using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC01.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        List<Product> products = new List<Product> { new Product {Id=1,ProductName="Iphone",UnitPrice=100 },
        new Product {Id=2,ProductName="Samsung",UnitPrice=200 },
        new Product {Id=3,ProductName="Lenovo",UnitPrice=300 },
        };

        public ActionResult Create()
        {
            // ProductName, UnitPrice bilgilerini
            Product p = new Product { Id = 4, ProductName = "xiaomi", UnitPrice = 250 };
            bool check = false;
            foreach (var item in products)
            {
                if (item.Id==p.Id)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                products.Add(p);
            }
            
            ViewData["Id"] = p.Id;
            ViewData["Name"] = p.ProductName;
            ViewData["UnitPrice"] = p.UnitPrice;
            return View();
        }
        public ActionResult Delete()
        {
            Product p = new Product { Id = 4, ProductName = "xiaomi", UnitPrice = 250 };
            ViewBag.Message = "";
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id==p.Id)
                {
                    products.RemoveAt(i);
                    ViewBag.Message = "Ürün silindi";

                }
            }
            
           
            ViewData["Id"] = p.Id;
            ViewData["Name"] = p.ProductName;
            ViewData["UnitPrice"] = p.UnitPrice;
            return View();
        }
        public ActionResult Update()
        {
            Product p = new Product { Id = 3, ProductName = "xiaomi", UnitPrice = 300 };
           
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == p.Id)
                {
                    products[i].ProductName = p.ProductName;
                    products[i].UnitPrice = p.UnitPrice;
                    ViewBag.Message = "Ürün güncellendi";

                }
            }


            ViewData["Id"] = p.Id;
            ViewData["Name"] = p.ProductName;
            ViewData["UnitPrice"] = p.UnitPrice;
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
    }
}
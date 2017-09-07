using Lesson3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson3.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Каяк",
            Description = "Лодка на одного человека",
            Category = "Водные виды спорта",
            Price = "275"
        };
        // GET: Home
        public ActionResult Index()
        {
            return View(myProduct);
        }

        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }

        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }

        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product {Name="Каяк", Price="275"},
                new Product {Name="Спасательный жилет", Price="15.99"},
                new Product {Name="Футбольный мяч", Price="12"},
                new Product {Name="Угловой флажек", Price="17.01"}
            };
            return View(array);
        }
    }
}
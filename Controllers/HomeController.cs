using bshoestore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bshoestore.Controllers
{
    //This will be my homepage
    public class HomeController : Controller
    {
        private ShoesEntities db = new ShoesEntities();


        public ActionResult Index()
        {
            var products = from i in db.Products
                           select i;
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpPost]
        public ActionResult AddToCart(int ID)   
        {
            Product product = db.Products.Find(ID);
            Cart basket = new Cart();
            basket.AddItem(new Product
            {
                Model = ((product.Model)),
                Size = ((product.Size)),
                Description = ((product.Description)),
                Price = (product.Price),

                Id = IdSetter.setId()
            });
            basket.DisplayFor(IdSetter.setId());
            IdSetter.incrementId();
            //seed++;
            return RedirectToAction("Index");
        }
    }
}
}
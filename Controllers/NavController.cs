using bshoestore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace bshoestore.Controllers
{
    public class NavController : Controller
    {
        private readonly ShoesEntities db;
        public NavController()
        {
            db = new ShoesEntities();
        }
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = db.Products
                                    .Select(x => x.Category)
                                    .Distinct()
                                    .OrderBy(x => x);

            return PartialView(categories);
        }

        //public PartialViewResult Submenu(string genre = null)
        //{
        //    ViewBag.SelectedGenre = genre;

        //    IEnumerable<string> genres = db.Products
        //                            .Select(x => x.Genre)
        //                            .Distinct()
        //                            .OrderBy(x => x);

        //    return PartialView(genres);
        //}
    }
}
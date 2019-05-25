using bshoestore.Models;
//using bshoestore.Models.HtmlHelpers;
using bshoestore.Models.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace bshoestore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ShoesEntities db;
        public int PageSize = 4;
        public ProductController()
        {
            db = new ShoesEntities();
        }

        public ViewResult List(string category)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = db.Products
                .Where(p => category == null || p.Category == category)
                        .OrderBy(p => p.ProductId)
            };
                  return View(model);
        }
    }
}
            
        
    
                        //.Skip((page - 1) * PageSize)
                        //.Take(PageSize),
                //PagingInfo = new PagingInfo
                
                //    CurrentPage = page,
                //    ItemsPerPage = PageSize,
                //    TotalItems = category == null ?
                //    db.Products.Count() :
                //    db.Products.Where(p => p.Category == category).Count()
                //},
                //CurrentCategory = category
         




        //public ViewResult GenreList(string genre, int page = 1)
        //{
        //    ProductsListViewModel model = new ProductsListViewModel
        //    {
        //        Products = db.Products
        //        .Where(p => genre == null || p.Genre == genre)
        //                .OrderBy(p => p.ProductId)
        //                .Skip((page - 1) * PageSize)
        //                .Take(PageSize),
        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = page,
        //            ItemsPerPage = PageSize,
        //            TotalItems = genre == null ?
        //            db.Products.Count() :
        //            db.Products.Where(p => p.Category == genre).Count()
        //        },
        //        CurrentGenre = genre
        //    };
        //    return View(model);

        //}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eshop.Models; //statement(afirmatie) pt a vedea clasele din Models
using System.Data.Entity;

namespace Eshop.Controllers
{
    public class CategoriesController : Controller
    {
        //private object Id_Category;

        //// GET: Categories
        //[HttpGet]
        //public ViewResult Categories()
        //{
        //    using (var ctx = new ShoppingStoreDB())
        //        return View(ctx.Set<Category>().OrderBy(model => model.Id_Category));

        //    // Has to be ordered in database query scenarios for paging to work!
        //}

        //private ViewResult View(object p)
        //{
        //    throw new NotImplementedException();
        //}

        //public ActionResult Index()
        //{
        //    var category = new List<Models.Category>
        //    {
        //        new Models.Category {Name = "Category1"},
        //        new Models.Category {Name = "Category2"},
        //        new Models.Category {Name = "Category3"}
        //    };
        //    return View(category);

        //}

        public ActionResult BrowseCategory(string category)
        {
            //string message = HttpUtility.HtmlEncode("showing category" + category); //HttpUtility.HtmlEncode reprezinta Convertește un string într-un șir HTML codificat.
            var categoryModel = new Models.Category { Name = category };
            return View(categoryModel);

        }

        public ActionResult Item()
        {

            var item = new List<Item>
            {
                new Item {Id_Item = 1},
                new Item {Id_Item = 2},
                new Item {Id_Item = 3}
            };
            return View(item);

        }

        public ActionResult BrowseItem()
        {
            var itemModel = new Item { Id_Item = 0 };
            return View(itemModel);
        }

        

        public ActionResult Categories()
        {
            var category = new List<Models.Category>
            {
                    new Models.Category {Name = "Category1"},
                    new Models.Category {Name = "Category2"},
                    new Models.Category {Name = "Category3"}
            };
            return View(category);
        }
      
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eshop.Models; //statement(afirmatie) pt a vedea clasele din Models

namespace Eshop.Controllers
{
    public class StoreController : Controller
    {
        private int item;

        // GET: Store
        public ActionResult Index()
        {
            var category = new List<Category>
            {
                new Category {Name = "Category1"},
                new Category {Name = "Category2"},
                new Category {Name = "Category3"}
            };
            return View(category);

        }

        public ActionResult BrowseCategory(string category)
        {
            //string message = HttpUtility.HtmlEncode("showing category" + category); //HttpUtility.HtmlEncode reprezinta Convertește un string într-un șir HTML codificat.
            var categoryModel = new Category { Name = category };
            return View(categoryModel);

        }

        public ActionResult Item()
        {

            var item = new List<Item>
            {
                new Item {Id = 1},
                new Item {Id = 2},
                new Item {Id = 3}
            };
            return View(item);

        }

        public ActionResult BrowseItem()
        {
            var itemModel = new Item { Id = item };
            return View(itemModel);
        }

        //public ActionResult Details(int id)
        //{
        //    var Item = new Item { ItemId = "Item" + id }; // var = Acesta trebuie să fie utilizat atunci când se stochează o referință la un obiect de tip anonim, deoarece numele de tip nu poate fi cunoscut în prealabil: var foo = new {Bar = "bar"};
        //    return View(Item);
        //}
    }
}
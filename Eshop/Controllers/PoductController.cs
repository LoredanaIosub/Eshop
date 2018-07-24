using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eshop.Models; //statement(afirmatie) pt a vedea clasele din Models

namespace Eshop.Controllers
{
    public class Product : Controller
    {
        public ActionResult Index()
        {
            var category = new List<Models.Product>
            {
                new Models.Product {Name = "Product1"},
                new Models.Product {Name = "Product2"},
                new Models.Product {Name = "Product3"}
            };
            return View(category);

        }

        public ActionResult BrowseProduct(string Product)
        {
            var categoryModel = new Models.Product { Name = product };
            return View(productModel);
        }

}
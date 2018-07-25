using Eshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshop.Controllers
{
    public class ProductsGridController : Controller
    {
        // GET: ProductsGrid
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductsGrid()
        {
            IList<Contact> products;

            using (var context = new ShoppingStoreDB())
            {
                products = context.Products.ToList();
            }

            return View(products);
        }

        public ActionResult Delete(int id)
        {
            using (var ctx = new ShoppingStoreDB())
            {
                var product = ctx.Products.Find(id);
                if (product != null)
                {
                    ctx.Contacts.Remove(product);
                    ctx.SaveChanges();
                }
            }

            return RedirectToAction("ProductsGrid");
        }
    }


}
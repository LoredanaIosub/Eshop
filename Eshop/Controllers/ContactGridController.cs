using Eshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshop.Controllers
{
    public class ContactGridController : Controller
    {
        // GET: ContactGrid
        public ActionResult Index()
        {
            return View();
        }

        private ShoppingStoreDB ctx = new ShoppingStoreDB();

        public ActionResult ContactGrid()
        {
            return View(ctx.Contacts.ToList());
        }

    }

}
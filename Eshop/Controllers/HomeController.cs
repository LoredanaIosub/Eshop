using Eshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eshop.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Contact model = new Contact();
            model.FirstName = "Alan";
            model.LastName = "Ion";
            model.Phone = 0722433444;
            model.Message = "Bine ai venit!";
            model.Id_Contact = 0;
            model.Email = "sasss@gmai.com";
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            if(ModelState.IsValid)
            {
                if (contact.Id_Contact == 0)
                {
                   using(var ctx = new ShoppingStoreDB())
                    {
                        ctx.Contacts.Add(contact);
                        ctx.SaveChanges();
                    }
                }
                // to do update contact7
            }

            return View(contact);
        }
       
    }
}
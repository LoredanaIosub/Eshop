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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Contact model = new Contact();
            model.FirstName = "Alan";
            model.LastName = "Ion";
            model.Phone = 0722;
            model.Message = "Bine ai venit!";
            model.Id = 0;
            model.Email = "sasss@gmai.com";
            return View(model);
        }


        //public ActionResult Produse()
        //{
        //    ViewBag.Message = "Hello";

        //    return View();
        //}
    }
}
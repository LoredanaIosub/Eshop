﻿using Eshop.Models;
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

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Contact model = new Contact();
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                using (var ctx = new ShoppingStoreDB())
                {
                    ctx.Contacts.Add(contact);
                    ctx.SaveChanges();
                }
            } 
            return View(contact);
        }

       




    

    }
}
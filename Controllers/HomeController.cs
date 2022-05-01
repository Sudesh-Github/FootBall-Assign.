using FootBallNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.IO;
using System.Data.Entity;

namespace FootBallNew.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext context = new MyDbContext();
        public ActionResult Index()
        {
            return View(context.Matches);
        }

        public ActionResult Create()
        {
            return View();
        }


        public ActionResult CreateAccount(Match a)
        {
            context.Matches.Add(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult CreateAccount(Match a)
        //{       

        //    ViewBag.result = "Match Details Inserted Successfully!";
        //    return View();

        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_1_Overwatch.Controllers
{
    public class HeroesController : Controller
    {
        // GET: Heroes
        public ActionResult heroDetails(string name)
        {
            ViewBag.name = name;
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        
    }
}
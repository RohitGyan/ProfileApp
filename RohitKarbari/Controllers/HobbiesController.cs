using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RohitKarbari.Controllers
{
    public class HobbiesController : Controller
    {
        // GET: Hobbies
        public ActionResult Hobbies()
        {
          ViewBag.Hobbie = new List<string> { "Cricket", "travelling", "music", "batminton"};
            foreach (var Hobbie in @ViewBag.Hobbie) ;
            
            return View();
        }
    }
}


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
            string[] hobbies = new string[4] { "Cricket", "Travelling", "Music", "Batminton" };
            ViewBag.Hobbies = hobbies;

            return View();
        }
    }
}


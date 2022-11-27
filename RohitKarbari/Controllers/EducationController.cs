using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RohitKarbari.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Index()
        {
            ViewBag.Degree = "Bachlore of Engineering";
            ViewBag.SchoolName = "The Mellinium Public School";
            ViewBag.Stream = "SSLC";
            ViewBag.Percentage = "72%";

            ViewBag.CollegeName = "Nandi International PU College";
            ViewBag.CollegeStream = "PCMC";
            ViewBag.CollegePercentage = "70%";
            return View();
        }
    }
}
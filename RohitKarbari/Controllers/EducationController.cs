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
        public ActionResult Education()
        {
            ViewBag.DegreeCollege = "LAEC";
            ViewBag.DegreeStream = "B.E Civil";
            ViewBag.DegreePercentage = "54%";

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
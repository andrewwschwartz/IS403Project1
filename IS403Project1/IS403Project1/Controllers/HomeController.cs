using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS403Project1.Controllers
{
    //This is my comment
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
            List<SelectListItem> subjects = new List<SelectListItem>();
            subjects.Add(new SelectListItem { Text = "one", Value = "0" });
            subjects.Add(new SelectListItem { Text = "two", Value = "1" });
            subjects.Add(new SelectListItem { Text = "three", Value = "2" });
            ViewBag.subjects = subjects;

            ViewBag.Message = "Your contact page.";

            ViewBag.Subject = "Subject";

            return View();

        }

        public ActionResult updateSubject()
        {
            ViewBag.Subject = "One";

            return View();
        }
    }
}
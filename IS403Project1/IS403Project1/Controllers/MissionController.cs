using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS403Project1.Controllers
{
    public class MissionController : Controller
    {
        // GET: Mission
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MissionPage(string iMishName)
        {
            if (iMishName == "Brazil")
            {
                ViewBag.MishName = iMishName;
                ViewBag.PresName = "President Dude";
                ViewBag.MishAddress = "123 Futbol Sao Paolo, Brazil";
                ViewBag.Language = "Portuguese";
                ViewBag.Climate = "Hot and steamy";
                ViewBag.Religion = "Catholics";
                ViewBag.Picture = "Brazil.png";
            }

            else if (iMishName == "New York")
            {
                ViewBag.MishName = iMishName;
                ViewBag.PresName = "President Dude";
                ViewBag.MishAddress = "123 Manhattan New York, New York";
                ViewBag.Language = "English/Spanish";
                ViewBag.Climate = "Hot and cold";
                ViewBag.Religion = "Jehovah's Witness";
                ViewBag.Picture = "New York.jpg";
            }

            else if (iMishName == "Arizona")
            {
                ViewBag.MishName = iMishName;
                ViewBag.PresName = "President Dude";
                ViewBag.MishAddress = "123 Futbol Sao Paolo, Arizona";
                ViewBag.Language = "English";
                ViewBag.Climate = "Hot and steamy";
                ViewBag.Religion = "Catholics";
                ViewBag.Picture = "Arizona.jpg";
            }

            return View();
        }
    }
}
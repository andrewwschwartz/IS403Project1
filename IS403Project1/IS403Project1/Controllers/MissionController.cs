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
                ViewBag.PresName = "President Tanner";
                ViewBag.MishAddress = "123 Futbol Sao Paolo, Brazil";
                ViewBag.Language = "Portuguese";
                ViewBag.Climate = "High humidity, varied weather according to season. No snow and stays above freezing";
                ViewBag.Religion = "Catholicism and Evangelical";
                ViewBag.Picture = "Brazil.png";
            }

            else if (iMishName == "New York")
            {
                ViewBag.MishName = iMishName;
                ViewBag.PresName = "President Calderwood";
                ViewBag.MishAddress = "123 Manhattan New York, New York";
                ViewBag.Language = "English/Spanish";
                ViewBag.Climate = "High Humidity, very hot in the summer and very cold in the winter. Usually snows during winter months";
                ViewBag.Religion = "Catholicism";
                ViewBag.Picture = "NewYork.jpg";
            }

            else if (iMishName == "Arizona")
            {
                ViewBag.MishName = "Mesa " + iMishName;
                ViewBag.PresName = "President Jenkins";
                ViewBag.MishAddress = "123 Stapley Dr Mesa, Arizona";
                ViewBag.Language = "English";
                ViewBag.Climate = "Super Hot and very dry";
                ViewBag.Religion = "Mormon";
                ViewBag.Picture = "Arizona.jpg";
            }

            return View();
        }
    }
}
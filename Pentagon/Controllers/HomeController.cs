using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pentagon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our Location Page.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Services Page";

            return View();
        }

        public ActionResult LiveStatus()
        {
            ViewBag.Message = "Live Status Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Settings()
        {
            ViewBag.Message = "Your Settings page.";

            return View();
        }
    }
}
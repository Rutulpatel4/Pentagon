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
            ViewBag.Message = "Our Location";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Services";

            return View();
        }

        public ActionResult LiveStatus()
        {
            ViewBag.Message = "Live Status";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Information";

            return View();
        }

        public ActionResult Settings()
        {
            ViewBag.Message = "Settings";

            return View();
        }

        public ActionResult EmpLive()
        {
            ViewBag.Message = "Employee Live Location";

            return View();
        }
    }
}
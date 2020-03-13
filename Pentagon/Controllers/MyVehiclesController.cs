using Pentagon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pentagon.Controllers
{
    public class MyVehiclesController : Controller
    {

        private DbModel db = new DbModel();

        // GET: MyVehicles
        public ActionResult Index()
        {
            var vehicletype = db.vehicles.OrderBy(d => d.vehicleType).ToList();
            var make = db.vehicles.OrderBy(a => a.make).ToList();
            var model = db.vehicles.OrderBy(a => a.model).ToList();
            return View(vehicletype);
        }



        public ActionResult VehicleType(string vehicletype)
        {
            var vehicles = db.vehicles.Where(a => a.vehicleType == vehicletype).ToList();
            return View(vehicles);
        }

        public ActionResult Make(string make)
        {
            var maketemp = db.vehicles.Where(a => a.make == make).ToList();
            return View(maketemp);
        }

        public ActionResult Model(string model)
        {
            var modeltemp = db.vehicles.Where(a => a.model == model).ToList();
            return View(modeltemp);
        }
    }

}


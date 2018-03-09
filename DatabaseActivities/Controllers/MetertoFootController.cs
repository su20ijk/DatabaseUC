using DatabaseActivities.Models.Entity;
using DatabaseActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class MetertoFootController : Controller
    {
        private MeterstoFeetService service = new MeterstoFeetService();
        // GET: MeterstoFeet
        public ActionResult Index()
        {
            return View(service.GetAllConversions());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateConversion(double Meters)
        {
            service.CreateConversions(Meters);
            return RedirectToAction("Index", "MetertoFoot");
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditConversion(MeterToFoot toSave)
        {
            service.SaveEdits(toSave);
            return RedirectToAction("Index", "MetertoFoot");
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteConversion(int Id)
        {
            service.DeleteConversion(Id);
            return RedirectToAction("Index", "MetertoFoot");
        }
    }
}

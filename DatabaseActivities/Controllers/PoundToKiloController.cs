using DatabaseActivities.Models.Entity;
using DatabaseActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class PoundToKiloController : Controller
    {
        private PoundToKiloService service = new PoundToKiloService();
        // GET: PoundToKilo
        public ActionResult Index()
        {
            return View(service.GetAllConversions());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateConversion(double Pounds)
        {
            service.AddConversion(Pounds);
            return RedirectToAction("Index", "PoundToKilo");
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditConversion(PoundToKilo toSave)
        {
            service.SaveEdits(toSave);
            return RedirectToAction("Index", "PoundToKilo");
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteConversion(int Id)
        {
            service.DeleteConversion(Id);
            return RedirectToAction("Index", "PoundToKilo");
        }
    }
}
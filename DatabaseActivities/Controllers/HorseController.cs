using DatabaseActivities.Models.Entity;
using DatabaseActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class HorseController : Controller
    {
        private HorseService service = new HorseService();
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
        public ActionResult CreateConversion(double Horses)
        {
            service.AddConversion(Horses);
            return RedirectToAction("Index", "Horse");
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EditConversion(HorsetoBlock toSave)
        {
            service.SaveEdits(toSave);
            return RedirectToAction("Index", "Horse");
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteConversion(int Id)
        {
            service.DeleteConversion(Id);
            return RedirectToAction("Index", "Horse");
        }
    }
}
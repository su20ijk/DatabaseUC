using DatabaseActivities.Models.Entity;
using DatabaseActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class GramsToOunceController : Controller
    {
        // GET: GramsToOunce

        private GramsToOunceService service = new GramsToOunceService();

        public ActionResult Index()
        {
            return View(service.GetAllConversions());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateConversion(double Grams)
        {
            service.AddConversion(Grams);
            return RedirectToAction("Index", "GramsToOunce");
        }

		public ActionResult Delete()
		{
			return View();
		}
		[HttpPost]
		public ActionResult DeleteConversion(int Id)
		{
			service.DeleteConversion(Id);
			return RedirectToAction("Index", "GramsToOunce");
		}

		public ActionResult Edit()
		{
			return View();
		}
		[HttpPost]
		public ActionResult EditConversion(int Id, double Grams)
		{
			service.SaveEdits(Id, Grams);
			return RedirectToAction("Index", "GramsToOunce");
		}
	}
}
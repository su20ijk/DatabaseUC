using DatabaseActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseActivities.Controllers
{
    public class GramOunceController : Controller
    {
        // GET: GramOunce

        private GramOunceService service = new GramOunceService();

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
            return RedirectToAction("Index", "GramOunce");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DatabaseActivities.Models;
using DatabaseActivities.Models.Entity;
using DatabaseActivities.Service;

namespace DatabaseActivities.Controllers
{
    public class BaseController : Controller
    {
        private BaseService service = new BaseService();
        public ActionResult Index()
        {
            return View(service.GetAllBase());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Base bases = service.GetBaseById((int)id);
            if (bases == null)
            {
                return HttpNotFound();
            }
            return View(bases);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StartingBase,StartingNumber,ActualNumber")] Base bases)
        {
            if (ModelState.IsValid)
            {
                bases.ActualNumber = Calculation(bases.StartingBase, bases.StartingNumber);
                service.AddBase(bases);
                return RedirectToAction("Index");
            }

            return View(bases);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Base bases = service.GetBaseById((int)id);
            if (bases == null)
            {
                return HttpNotFound();
            }
            return View(bases);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Base bases = service.GetBaseById(id);
            service.DeleteBase(bases);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public int Calculation(int StartingBase, int StartingNumber)
        {
            return service.CalculateActualNumber(StartingBase, StartingNumber);
        }
    }
}
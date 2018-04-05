using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDemo.Controllers
{
    public class BusController : Controller
    {

        private BusRepository repo = new BusRepository();
        // GET: Bus
        public ActionResult Index()
        {
            return View(this.repo.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Bus bus)
        {
            if (ModelState.IsValid)
            {
                this.repo.Insert(bus);
                return RedirectToAction("Create", "Seat", bus);
            }
            else
            {
                return View(bus);
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(this.repo.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Bus bus)
        {
            if (ModelState.IsValid)
            {
                this.repo.Update(bus);
                return RedirectToAction("Index");
            }
            else
            {
                return View(bus);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(this.repo.Get(id));
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(this.repo.Get(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            this.repo.Delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Seat(int id)
        {
            return RedirectToAction("View", "Seat", new { id = id });

        }
    }
}
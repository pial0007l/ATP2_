using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDemo.Controllers
{
    public class PassengerController : Controller
    {
        private BusRepository repo = new BusRepository();
        private PassengerRepository repo2 = new PassengerRepository();
        // GET: Passenger
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create(int id)
        {
            return View();
        }
        [HttpPost, ActionName("Create")]
        public ActionResult Store(Passenger pass, int id)
        {
            var bus = this.repo.Get(id);
            pass.DepartureDate = bus.DepartureDate;
            pass.Boarding = bus.StartingCounter;
            pass.BusID = bus.Id;
            this.repo2.Insert(pass);
            return RedirectToAction("Seat", "Home", new { id = pass.Id});
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(this.repo.Get(id));
        }
        [HttpGet]
        public ActionResult Seats(int id)
        {
            return RedirectToAction("View", "Seat", new { id = id });
        }
    }
}
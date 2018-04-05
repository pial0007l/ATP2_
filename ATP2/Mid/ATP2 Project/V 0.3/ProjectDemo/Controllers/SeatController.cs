using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace ProjectDemo.Controllers
{
    public class SeatController : Controller
    {

        private SeatRepository repo = new SeatRepository();
        // GET: Seat
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(Bus bus)
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public ActionResult Store(Seat seat,Bus bus)
        {
            
            if (ModelState.IsValid)
            {

                 seat.Name = "A1";
                 seat.Status = false;
                 seat.BusID = bus.Id;
                 seat.DepartureDate = bus.DepartureDate;
                 seat.DepartureTime = bus.DepartureTime;
                 this.repo.Insert(seat);

                seat.Name = "A2";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "A3";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "A4";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "B1";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "B2";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "B3";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "B4";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "C1";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "C2";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "C3";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "C4";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "D1";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "D2";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "D3";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "D4";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "E1";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "E2";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "E3";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "E4";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "F1";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "F2";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "F3";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "F4";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "G1";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "G2";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "G3";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "G4";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "H1";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "H2";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "H3";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                seat.Name = "H4";
                seat.Status = false;
                seat.BusID = bus.Id;
                seat.DepartureDate = bus.DepartureDate;
                seat.DepartureTime = bus.DepartureTime;
                this.repo.Insert(seat);

                return RedirectToAction("Index", "Bus");
            }
            else
            {
                return RedirectToAction("Index", "Bus");
            }
        }
        [HttpGet]
        public ActionResult View(int id)
        {

            return View("ViewSeats", this.repo.GetAll_(id));
        }

    }
}
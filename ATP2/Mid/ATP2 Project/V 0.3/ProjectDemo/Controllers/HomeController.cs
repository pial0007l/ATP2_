using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ProjectDemo.Controllers
{
  
    public class HomeController : Controller
    {
        static int passId;
        private BusRepository repo = new BusRepository();
        private SeatRepository repo2 = new SeatRepository();
        private PassengerRepository repo3 = new PassengerRepository();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost, ActionName("Index")]
        public ActionResult ViewBuses()
        {
            String starting = Request.Form["starting"];
            String ending = Request.Form["ending"];
            String date = Request.Form["date"];
            String type = Request.Form["type"];

            //var data = this.repo.GetAll_(starting, ending, date, type);
            return View("ViewBuses",this.repo.GetAll_(starting, ending, date, type));
           // return View(this.repo.GetAll_(starting,ending,date,type));
        }
        [HttpGet]
        public ActionResult Seat(int id)
        {
            passId = id;
            var pass = this.repo3.Get(id);
            return View("ViewSeats", this.repo2.GetAll_(pass.BusID));
        }
        public ActionResult Ticket()
        {
            var pass = this.repo3.Get(passId);

            //ViewBag.Seat = this.repo2.SeatsOfPassengers(pass.Id);
            ViewBag.Passenger = pass;
            
            return View();
        }
        public ActionResult Buy(int id)
        {
            var seat = this.repo2.Get(id);
            var bus = this.repo.Get(seat.BusID);
            var passenger = this.repo3.Get(passId);
            if (seat.Status == false)
            {
                seat.Status = true;
                seat.PassengerID = passenger.Id;
                repo2.Buy(seat);
                return View("ViewSeats", this.repo2.GetAll_(seat.BusID));
            }
            else
            {
                return View("ViewSeats", this.repo2.GetAll_(seat.BusID));
            }
            
            
        }
        public ActionResult Passenger(int id)
        {
            return RedirectToAction("Create", "Passenger", new { id = id });
        }
    }
}
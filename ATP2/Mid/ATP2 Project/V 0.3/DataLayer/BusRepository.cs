using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BusRepository : IBusRepository
    {
        private DataContext context;

        public BusRepository() { this.context = new DataContext(); }
        public int Delete(int id)
        {
            Bus busToDelete = this.context.Buses.SingleOrDefault(e => e.Id == id);
            this.context.Buses.Remove(busToDelete);
            return this.context.SaveChanges();
        }
        public List<Bus> GetAll_(String starting,String ending,string date ,string type)
        {
            var data= this.context.Buses.ToList();
            data=data.Where(m =>m.StartingCounter== starting).ToList();
            data = data.Where(m => m.EndingCounter == ending).ToList();
            //data = data.Where(m => m.DepartureDate.ToString() == date.ToString()).ToList();
            data = data.Where(m => m.CoachType == type).ToList();
            return data;

        }

        public Bus Get(int id)
        {
            return this.context.Buses.SingleOrDefault(b => b.Id == id);
        }

        public List<Bus> GetAll()
        {
            return this.context.Buses.ToList();
        }

        public int Insert(Bus bus)
        {
            this.context.Buses.Add(bus);
            return this.context.SaveChanges();
        }

        public int Update(Bus bus)
        {
            Bus busToUpdate = this.context.Buses.SingleOrDefault(b => b.Id == bus.Id);
            busToUpdate.Name = bus.Name;
            busToUpdate.Route = bus.Route;
            busToUpdate.DepartureDate = bus.DepartureDate;
            busToUpdate.DepartureTime = bus.DepartureTime;
            busToUpdate.StartingCounter = bus.EndingCounter;
            busToUpdate.EndingCounter = bus.EndingCounter;
            busToUpdate.Fare = bus.Fare;
            busToUpdate.CoachType = bus.CoachType;
            busToUpdate.ArivalTime = bus.ArivalTime;
            busToUpdate.SeatAvailable = bus.SeatAvailable;

            return this.context.SaveChanges();
        }
    }
}

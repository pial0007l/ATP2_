using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PassengerRepository : IPassengerRepository
    {
        private DataContext context;

        public PassengerRepository() { this.context = new DataContext(); }

        public int Delete(int id)
        {
            Passenger passengerToDelete = this.context.Passengers.SingleOrDefault(e => e.Id == id);
            this.context.Passengers.Remove(passengerToDelete);
            return this.context.SaveChanges();
        }

        public Passenger Get(int id)
        {
            return this.context.Passengers.SingleOrDefault(b => b.Id == id);
        }

        public List<Passenger> GetAll()
        {
            return this.context.Passengers.ToList();
        }

        public int Insert(Passenger pass)
        {
            this.context.Passengers.Add(pass);
            return this.context.SaveChanges();
        }

        public int Update(Passenger pass)
        {
            throw new NotImplementedException();
        }
    }
}

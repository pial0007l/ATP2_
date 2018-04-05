using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SeatRepository : ISeatRepository
    {
        private DataContext context;

        public SeatRepository() { this.context = new DataContext(); }
        public List<Seat> GetAll()
        {
            return this.context.Seats.ToList();
        }

        public int Insert(Seat seat)
        {
            this.context.Seats.Add(seat);
            return this.context.SaveChanges();
        }
        public List<Seat> SeatsOfPassengers(int id)
        {
            var data = this.context.Seats.ToList();
            data = data.Where(m => m.PassengerID == id).ToList();
            return data;
        }
        public List<Seat> GetAll_(int id)
        {
            var data = this.context.Seats.ToList();
            data = data.Where(m => m.BusID == id).ToList();
            return data;

        }
        public int Update(Seat seat)
        {
            Seat seatToUpdate = this.context.Seats.SingleOrDefault(s => s.Id == seat.Id);
            seatToUpdate.Status =true;
            return this.context.SaveChanges();
        }
        public Seat Get(int id)
        {
            return this.context.Seats.SingleOrDefault(s => s.Id == id);
        }
        public int Buy(Seat seat)
        {
            Seat seatToUpdate = this.context.Seats.SingleOrDefault(s => s.Id == seat.Id);
            return this.context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IPassengerRepository
    {
        List<Passenger> GetAll();
        Passenger Get(int id);
        int Insert(Passenger pass);
        int Update(Passenger pass);
        int Delete(int id);
    }
}

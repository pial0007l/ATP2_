using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface ISeatRepository
    {
        List<Seat> GetAll();
        int Insert(Seat seat);
        int Update(Seat Seat);
    }
}

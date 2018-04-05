using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IBusRepository
    {
        List<Bus> GetAll();
        Bus Get(int id);
        int Insert(Bus bus);
        int Update(Bus bus);
        int Delete(int id);
    }
}

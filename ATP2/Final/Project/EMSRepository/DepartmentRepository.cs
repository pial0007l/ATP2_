using EMSEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSRepository
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public Department GetDepartment(string departmentName)
        {
            throw new NotImplementedException();
        }
    }
}

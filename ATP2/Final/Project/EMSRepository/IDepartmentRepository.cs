using EMSEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSRepository
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Department GetDepartment(string departmentName);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMSEntity
{
    public class Employee : Entity
    {
        public string Name { get; set; }
        public float Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}

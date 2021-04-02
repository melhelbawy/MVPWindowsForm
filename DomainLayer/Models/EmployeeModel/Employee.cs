using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.EmployeeModel
{
    public class Employee
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string DepartmentId { get; set; } // We are using Guid in relations
        public bool? IsActive { get; set; }
    }
}

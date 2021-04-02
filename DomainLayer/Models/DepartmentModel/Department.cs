using Domain.Models.EmployeeModel;
using System;
using System.Collections.Generic;

namespace Domain.Models.DepartmentModel
{
    public class Department
    {
        public Guid ID { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}

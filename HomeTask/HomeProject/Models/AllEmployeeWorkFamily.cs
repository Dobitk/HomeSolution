using System.Collections;
using System.Collections.Generic;
using HomeProject.Models;

namespace HomeProject.Models
{
    public class AllEmployeeWorkFamily
    {

        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<WorkHistory> WorkHistories { get; set; }
        public IEnumerable<Family> Families { get; set; }

    }
}




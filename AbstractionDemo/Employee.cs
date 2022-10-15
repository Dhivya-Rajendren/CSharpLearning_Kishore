using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class Employee  //-Domain Data/Domain class
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Contact { get; set; }

        public string PersonalEmail { get; set; }
        public string OfficialEmail { get; set; }
        public string Address { get; set; }

        public bool IsActive { get; set; }

     
    }
}

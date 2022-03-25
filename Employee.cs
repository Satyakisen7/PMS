using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Experience { get; set; }
        public string Designation {get; set; }
        public int BasicPay { get; set; }
        public int GrossPay { get; set; }
        public int DepartmentID { get; set; }

    }
}

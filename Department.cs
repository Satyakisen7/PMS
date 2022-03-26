using PMS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    public class Department: IDepartment
    {
        public Department(string deptName)
        {
            DepartmentName = deptName;
            Random random = new Random();
            DepartmentID = random.Next(100, 1000);
        }

        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public int addDeptment(string deptName)
        {
            DepartmentName = deptName;
            Random random = new Random();
            DepartmentID = random.Next(100, 1000);
            return DepartmentID;
        }
    }
}

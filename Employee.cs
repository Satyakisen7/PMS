using PMS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    public class Employee 
    {
        public Employee() {
            Random random = new Random();
            EmployeeID = random.Next();
            FullName = "rana";
            Experience = 0;
            Designation = null;
            BasicPay = 0;
            DepartmentID = 0;
        }

        public Employee(string name,DateTime DOB,int exp,string desg,int basic,int dept) { 
            Random random = new Random();
            EmployeeID = random.Next();
            FullName = name;
            Experience = exp;
            Designation = desg;
            BasicPay = basic;
            DepartmentID = dept;
            GrossPay = 0;
        }

        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Experience { get; set; }
        public string Designation {get; set; }
        public int BasicPay { get; set; }
        public int GrossPay { get; set; }
        public int DepartmentID { get; set; }

        public override string ToString()
        {
            return "["+ this.EmployeeID+ ","+this.FullName+ "," + this.DateOfBirth+ "," + this.Experience
                + "," + this.Designation+ "," + this.BasicPay+ "]";
        }



    }
}

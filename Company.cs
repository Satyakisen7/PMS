using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    abstract class Company
    {
        public int addDepartment(string deptName) { return addDepartment(deptName); }
        public int addEmployee(IEmployee e, out int id) { return addEmployee(e, out id); }     
        public int editEmployee(int employee) { return editEmployee(employee); }

        public interface IEmployee
        {
            viewEmployee(int id) 

            viewEmployee(string name) 
        }
        public int deleteEmployee(int id) { return deleteEmployee(id); }
        public int viewStatistics(int id) { return viewStatistics(id); }
    }
}

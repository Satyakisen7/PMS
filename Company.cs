using PMS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    public class Company : ICompany,IEmployee,IDepartment
    {
        List<Employee> employees =new List<Employee>();
        List<Department> departments= new List<Department>();

        public int editEmployee(int employee) { return editEmployee(employee); }

        public int deleteEmployee(int id) { return deleteEmployee(id); }

        public int viewStatistics(int id) {
            int number = 0;
            foreach (Employee employee in employees)
            {
                if (employee.DepartmentID == id)
                    number++;
            }
            return number;
        }

        public int addEmployee(IEmployee e, out int id)
        {
            Employee emp = new Employee();
            id = emp.EmployeeID;
            employees.Add(emp);
            return emp.GrossPay;
        }

        public IEmployee viewEmployee(int id)
        {
            IEmployee emp=null;
            foreach(Employee employee in employees)
            {
                if (employee.EmployeeID == id)
                    emp = (IEmployee)employee;
            }
            return emp;
        }

        public IEmployee viewEmployee(string name)
        {
            IEmployee emp = null;
            foreach (Employee employee in employees)
            {
                if (employee.FullName.ToLower().Equals(name.ToLower()))
                    emp = (IEmployee)employee;
            }
            return emp;
        }

        public int addDeptment(string deptName)
        {
            Department dept = new Department(deptName);
            departments.Add(dept);
            return dept.DepartmentID;
        }
    }
}

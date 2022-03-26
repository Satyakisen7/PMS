using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Interfaces
{
    public interface IEmployee 
    {
        int addEmployee(IEmployee e, out int id);
        int editEmployee(int employee);
        IEmployee viewEmployee(int id);
        IEmployee viewEmployee(string name);
        int deleteEmployee(int id);
    }
}

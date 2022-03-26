using PMS.Interfaces;

namespace PMS
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Display the number of command line arguments.
            Console.WriteLine("Hello World");
            Company comp = new Company();
            Console.WriteLine(comp.addDeptment("ECE"));
            Console.WriteLine(comp.addDeptment("CS"));
            Console.WriteLine(comp.addDeptment("IT"));
            int id = 204;
            Console.WriteLine(comp.addEmployee(,out id));
            /*switch(choice)
            {
                case 1: 
                    comp.addDepartment()
            }*/
        }
    }
}
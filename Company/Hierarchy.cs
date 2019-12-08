using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{

  
    static class Hierarchy
    {
        public static void Show(Manager<Employee> employees, Developer<Project> projects, SalesEmployee<Sales> sales)
        {

            Console.WriteLine("Manager");
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Developers");
            foreach (var item in projects)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sales");
            foreach (var item in sales)
            {
                Console.WriteLine(item);
            }
        }
}
}

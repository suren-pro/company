using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Manager<Employee> manager = new Manager<Employee>()
            {


             new Employee{Id = 5, FirstName= "s", LastName = "b",Salary = 500,Department = Department.Accounting },
             new Employee{Id = 15, FirstName= "John", LastName = "b",Salary = 1500,Department = Department.Sales },
             new Employee{Id = 11115, FirstName= "s", LastName = "b",Salary = 5000,Department = Department.Marketing },
             };


            SalesEmployee<Sales> sales_employee= new SalesEmployee<Sales>()
            {
              new Sales{ ProductName ="Car",Price=5000},
              new Sales{ ProductName ="Ball",Price=50},
              new Sales{ ProductName ="Door",Price=550},

             };

            Developer<Project> developers = new Developer<Project>()
            {
                new Project{ ProjectName ="Car",details="Text",State=State.Closed},
                new Project{ ProjectName ="Bus",details="Text",State=State.Closed},
                new Project{ ProjectName ="Bycicle",details="Text",State=State.Open},
            

            };



            Customer customer = new Customer("Suren","Barseghyan",500);




            
            





            

            Hierarchy.Show(manager, developers, sales_employee);



            Console.WriteLine(customer);




        }
    }
}

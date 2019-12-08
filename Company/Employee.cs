using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface IEmployee
    {
        int Salary { get; set; }
        Department Department { get; set; }
        

    }
    class Employee:Person,IEmployee
    {

        public int Salary { get; set; }
        public  Department Department  { get; set; }
        string department_info;

        

        public override string ToString()
        {
            switch (this.Department)
            {
                case Department.Accounting:
                    this.department_info = "Accounting";
                    break;
                case Department.Marketing:
                    this.department_info = "Marketing";
                    break;
                case Department.Production:
                    this.department_info = "Production";
                    break;
                case Department.Sales:
                    this.department_info = "Sales";
                    break;

            }
            return $" ID :{Id}, Fullname :{FirstName} {LastName} ,Salary:{Salary}, Department:{department_info}";
        }

    }
}

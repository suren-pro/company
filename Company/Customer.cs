using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Customer:Person
    {


        int purchase;

        public int Purchase { get; set; }


        public Customer(string name,string lastname,int purchase)
        {
            this.FirstName = name;
            this.LastName = lastname;
            this.Purchase = purchase;
                
                
                
                
                
                }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, has spent {Purchase}";
        }

    }
}

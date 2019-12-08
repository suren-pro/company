using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface IPerson
    {
         int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Person : IPerson
    {
        public int Id { get ; set ; }
        public string FirstName { get; set; }
        public string LastName { get ; set ; }

       
    }
}

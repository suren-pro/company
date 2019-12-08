using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    interface ISales
    {
        string ProductName { get; set; }
        int Price { get; set; }

    }
    class Sales:ISales
    {
        public DateTime date = DateTime.Now;
        public string ProductName { get; set; }
        public int Price { get; set; }


        public override string ToString()
        {
            return $"Product Name: {ProductName},price:    {Price},DateTime:{date} ";
        }


    }
}

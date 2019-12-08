using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{


    enum State
    {

        Open,
        Closed

    }
    interface IProject
    {

        string ProjectName { get; set; }
        DateTime date { get; set; }
        string details { get; set; }
        State State { get; set; }

    }
    class Project:IProject
    {
       public string ProjectName { get; set; }
      public  DateTime date { get; set; }
      public  string details { get; set; }
     public   State State { get; set; }
        string state_info;


        public Project()
        {
            date = DateTime.Now;
        }
        public override string ToString()
        {
            switch (this.State)
            {
                case State.Open:
                    this.state_info = "Open";
                    break;
                case State.Closed:
                    this.state_info = "Closed";
                    break;
               

            }
            return $"Project Name :{ProjectName},Details:{details} ,DateTime:{date}, State:{state_info}";
        }
    }
}

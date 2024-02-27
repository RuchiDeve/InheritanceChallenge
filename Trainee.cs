using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class Trainee:Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(int workingHours, int schoolHours, String name, String firstName, int salary):base(name, firstName, salary)
        { 
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }
        public void Learn()
        {
            Console.WriteLine("I'm Learning for {0} hrs", SchoolHours);
        }
        public void Work()
        {
            Console.WriteLine("I work for {0} hrs", WorkingHours);
        }


    }
}

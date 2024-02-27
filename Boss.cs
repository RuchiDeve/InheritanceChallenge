using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InheritanceChallenge
{
    class Boss:Employee
    {
        public String CompanyCar { get; set; }

        public Boss(String companyCar, String name, String firstName, int salary):base(name, firstName, salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I'm boss");
        }
    }
}
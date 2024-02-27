using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    class Employee
    {
        public String Name { get; set; }
        public String FirstName { get; set; }
        public int Salary { get; set; }


        public Employee(string name, string firstName, int salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public Employee()
        {
            Name = "Okezie";
            FirstName = "Uruchi";
            Salary = 5000;
        }

        public void Work()
        {
            Console.WriteLine("I'm working");
        }
        public void Pause()
        {
            Console.WriteLine("I'm having a break");
        }
    }
}
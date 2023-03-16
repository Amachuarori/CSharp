using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Employee
    {
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected double Salary { get; set; }

        public Employee() { }

        public Employee(string name, string lastName, double salary)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Salary = salary;
        }


        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working");
        }

        public void Pause()
        {
            Console.WriteLine($"|{Name} stopped working");
        }




    }
}

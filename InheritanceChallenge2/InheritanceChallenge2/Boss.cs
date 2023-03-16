using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2
{
    internal class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string name, string lastName, int Salary, string companyCar)
        {
            this.Name = name;
            this.Salary = Salary;
            this.LastName = lastName;
            this.CompanyCar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine($"{Name} doing boss chores");
        }


    }
}

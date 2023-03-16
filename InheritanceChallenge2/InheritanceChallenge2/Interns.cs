using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InheritanceChallenge2
{
    internal class Interns : Employee
    {
        public int WorkingHours { get; set; }
        protected int schoolHours;

        public int currLearn = 0;

        Timer timer;
        

        public Interns(string name, string lastName, int salary, int schoolHours)
        {
            this.Name = name;
            this.Salary = salary;
            this.LastName = lastName;
            this.WorkingHours = 20;
            this.schoolHours = schoolHours;
            
        }


        public void Learn()
        {
            if(schoolHours > 0)
            {
                TimerCallback tm = new TimerCallback(Count);
                timer = new Timer(tm, null, 0, 1000);
                Console.ReadLine();
            }
            
            
        }

        private void Count(object o)
        {
            if (schoolHours > 0)
            {
                
                
                Console.WriteLine("time left {0}", schoolHours);
                schoolHours--;
                GC.Collect();
            }
            else
            {
                Work();
            }

        }

        public override void Work()
        {
            if(schoolHours > 0)
            {
                Console.WriteLine("intern is studying now, cant do any work");
                Learn();
            }
            else
            {
                Console.WriteLine($"{Name} can work only 20 hours per week, now he's availavle to work");
                timer.Dispose();
            }
        }

        
        
    }
}

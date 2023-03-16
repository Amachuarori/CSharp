using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOPTopics
{
    internal class ForDateTime
    {
        public void Run()
        {
            DateTime dateTime = new DateTime(2001, 03, 07);

            Console.WriteLine("My birthday is {0}", dateTime);

            //write todat date on a screen
            Console.WriteLine(DateTime.Today);
            //write current date and time 
            Console.WriteLine(DateTime.Now );

            Console.WriteLine(DateTime.UtcNow);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("tomorrow will  be " + tomorrow);
            Console.WriteLine("tomorrow day of week is " + tomorrow.DayOfWeek);

            Console.WriteLine("today's day of week is " + DateTime.Today.DayOfWeek);
            Console.WriteLine(GetFirstDayOfYear(2022));

            int daysInMonth = DateTime.DaysInMonth(2016, 2);
            Console.WriteLine(daysInMonth);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute {0}", now.Minute);

            // display the time in this structure x o'clock and y minutes and z seconds
            Console.WriteLine("current time is {0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan dayPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}", dayPassed.Days);
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        } 

        public DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        public DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

    }
}

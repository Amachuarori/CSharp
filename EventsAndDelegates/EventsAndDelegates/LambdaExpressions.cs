using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class LambdaExpressions
    {
        public delegate bool FilterDelegate(Person p);
        public void Run()
        {
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            string searchKeyword = "e";

            // ------LAMBDA EXPRESSIONS------
            DisplayPeople("age > 20 with a search keyword " + searchKeyword, people, (p) =>
            {
                if (p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            Console.WriteLine();

            // another way
            DisplayPeople("Exactly 25 yo: ", people, p => p.Age == 25);
        }

        static void DisplayPeople(string tittle, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(tittle);
            foreach (var e in people)
            {
                if (filter(e))
                {
                    Console.WriteLine("{0}, {1} years old", e.Name, e.Age);
                }
            }
        }

        // ==========Filters=========

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }
    }
}

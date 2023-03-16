using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventsAndDelegates
{
    internal class ForAnonymousMethods
    {
        //delegate void MessageHandler(string message);
        public delegate bool FilterDelegate(Person p);
        public void Run()
        {
            /*
            MessageHandler handler = delegate (string s)
            {
                Console.WriteLine("анонимный метод " + s);
            };
            handler("hello world!");    // анонимный метод
            */

            


            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);
            Console.WriteLine();

            FilterDelegate filter = delegate (Person p) // можно обойтись и без аргумента, но мы юзаем переменные класса
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            // ------LAMBDA EXPRESSIONS------
            string searchKeyword = "A";
            DisplayPeople("age > 20 with a search keyword " + searchKeyword, people, (p) =>
            {
                if(p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false; 
                }
            });

            // another way
            DisplayPeople("Exactly 25 yo: ", people, p => p.Age == 25);


            Console.WriteLine();

            DisplayPeople("between 20 and 30 ", people, filter);
            DisplayPeople("All: ", people, delegate (Person p) { return true; });
            
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

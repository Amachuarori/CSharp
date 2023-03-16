namespace EventsAndDelegates
{
    internal class Program
    {
        public delegate bool FilterDelegate(Person p);


        static void Main(string[] args)
        {
            Excercise15Lamda ex = new Excercise15Lamda();
            Console.WriteLine(ex.OperationGet("+", 4,5));



            /*
            LambdaExpressions le = new LambdaExpressions();
            
                le.Run();
            


            /*
            ForAnonymousMethods am = new ForAnonymousMethods();
            am.Run();
            

            /*
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);

            /*
            Excercise14Delegates ex = new Excercise14Delegates();
            ex.Run();

            /*
            DelegatesBasics db = new DelegatesBasics();
            db.Run();
            */
        }


        static void DisplayPeople(string tittle, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(tittle);
            foreach(var e in people)
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class DelegatesBasics
    {
        public void Run()
        {
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };
            Console.WriteLine("---Before---");
            foreach(var e in names)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            Console.WriteLine("---After---");

            names.RemoveAll(Filter);

            foreach(var e in names)
            {
                Console.WriteLine(e);
            }
        }

        bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}

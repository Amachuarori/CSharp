using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOPTopics
{
    internal class ForMathClass
    {
        public void Check()
        {
            double num1 = 13.3333;
            double num2 = 13.3123;
            Console.WriteLine(Math.Min(num1, num2));
            Console.WriteLine(Math.Max(num1, num2));
            Console.WriteLine(Math.PI);
            double num3 = 121;
            Console.WriteLine(Math.Sqrt(num3));
            Console.WriteLine("Always positive is {0}", Math.Abs(-25));
            Console.WriteLine(Math.Sin(Math.PI/ 6));
        }
    }
}

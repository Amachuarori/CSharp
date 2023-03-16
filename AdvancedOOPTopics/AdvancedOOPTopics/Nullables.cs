using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOPTopics
{
    internal class Nullables
    {
        public void Run()
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = null;
            double? num5 = 3.14157;

            bool? boolval = null;

            Console.WriteLine("our nullables are: {0},{1},{2},{3}" , num1, num2, num3, num4);

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("user is male");
            }
            else if(isMale == false)
            {
                Console.WriteLine("user is Female");
            }
            else
            {
                Console.WriteLine("No gender could be found/chosen");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;
            if(num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;
            }
            Console.WriteLine("Value of num8 is {0}", num8);

            // Shorter: the NULL COALESCING OPERATOR ??
            num8 = num6 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);
            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of num8 is {0}", num8);
        }
    }
}

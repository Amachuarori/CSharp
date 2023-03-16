using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOPTopics
{
    internal class Excercise
    {
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public  void Run(string line)
        {
            bool forAngle = int.TryParse(line, out var newAngle);
            if (!forAngle || newAngle < 0 || newAngle > 180)
            {
                Console.WriteLine("Check the input!");
            }
            else
            {
                Console.WriteLine(Math.Cos(ConvertToRadians(newAngle)));
                Console.WriteLine(Math.Sin(ConvertToRadians(newAngle)));
                Console.WriteLine(Math.Tan(ConvertToRadians(newAngle)));
            }
        }
    }
}

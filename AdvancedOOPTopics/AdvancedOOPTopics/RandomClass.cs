using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOPTopics
{
    internal class RandomClass
    {
        public void Run()
        {
            Random dice = new Random();
            int numEyes;

            for(int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);

            }
        }
    }
}

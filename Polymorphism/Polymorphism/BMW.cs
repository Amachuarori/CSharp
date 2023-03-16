using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // bmw IS a car 
    internal class BMW : Car
    {
        private string Model { get; set; }

        private string brand = "BMW";

        public BMW()
        {

        }


        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"Car models is {brand} {Model}");
            Console.WriteLine($" car's HP is {HP}");
            Console.WriteLine($"car color is {Color}");
        }

        public sealed override void Repair()
        {
            Console.WriteLine($" The {brand} {Model} was repaired");
        }



    }
}

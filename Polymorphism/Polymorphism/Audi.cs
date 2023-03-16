using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Audi :Car
    {
        private string Model { get; set; }

        private string brand = "Audi";

        public Audi(int hp, string color, string model):base(hp, color)
        {
            
            this.Model = model;
        }

        

        public override void ShowDetails()
        {
            Console.WriteLine($"Car models is {brand} {Model}");
            Console.WriteLine($" car's HP is {HP}");
            Console.WriteLine($"car color is {Color}");
        }

        public override void Repair()
        {
            Console.WriteLine($" The {brand} {Model} was repaired");
        }

    }
}

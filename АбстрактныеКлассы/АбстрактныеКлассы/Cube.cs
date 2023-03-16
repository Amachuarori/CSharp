using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АбстрактныеКлассы
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            Name = "Kube";
            Length = length;
        }


        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("The {0} has a length of {1}", Name, Length);
            Console.WriteLine("the volume is {0}", Volume());
        }
    }
}

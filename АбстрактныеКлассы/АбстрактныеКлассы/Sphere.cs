using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АбстрактныеКлассы
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }
        
        public Sphere(double radius)
        {
            Name = "Sphere";
            this.Radius = radius;
        }

        public override double Volume()
        {
            return (4 / 3) * Math.Pow(Radius, 3) * Math.PI;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("The Sphere has a radius of {0}", Radius);
            Console.WriteLine("the volume is {0}", Volume());
        }
    }
}

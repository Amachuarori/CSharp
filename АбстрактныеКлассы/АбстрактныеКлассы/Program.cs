using System.Runtime.CompilerServices;
using System.Security.Authentication;

namespace АбстрактныеКлассы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new Cube(3);
            cube.GetInfo();
            Console.WriteLine("");
            Sphere sphere = new Sphere(5);
            sphere.GetInfo();
            Console.WriteLine("");
            Shape sh = new Cube(4);
            sh.GetInfo();

            Shape[] shapes =
            {
                new Sphere(4),
                new Cube(5)
            };
            Console.WriteLine();

            foreach( var shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());
                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("this shape is not a cube");
                }

                if(shape is Cube)
                {
                    Console.WriteLine("this shape is a cube");
                }
                else
                {
                    Console.WriteLine("not a cube");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;
                Console.WriteLine("{0} has a volume of {1}", cube2.Name, cube2.Volume());
            }

            
        }
    }
}
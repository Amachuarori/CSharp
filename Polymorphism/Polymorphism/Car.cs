using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        protected int HP { get; set; }
        protected string Color { get; set; }

        // HAS A RELATIONSHIP
        protected CarInfo_HasArelation_ carInfo = new CarInfo_HasArelation_();

        public void SetCarIDInfo(int idnum, string owner)
        {
            carInfo.IDNum = idnum;
            carInfo.Owner = owner;
        }

        public void GetCarInfo()
        {
            Console.WriteLine("the car has an ID of {0} and is owned by {1}", carInfo.IDNum, carInfo.Owner);
        }

        public Car()
        {

        }

        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($" car's HP is {HP}");
            Console.WriteLine($"car color is {Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("car was repaired");
        }
    }
}

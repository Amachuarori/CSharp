using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class Excercise14Delegates
    {
        public delegate float OperationDelegate(float num1, float num2);
        public delegate void Operation();
        public void Run()
        {
            

            Console.WriteLine(ApplyOperation(25, 5, Add));
            Console.WriteLine(ApplyOperation(25, 5, Substract));
            Console.WriteLine(ApplyOperation(25, 5, Multiply));
            Console.WriteLine(ApplyOperation(25, 5, Divide));
        }

        public void Run2()
        {
            OperationDelegate op = Add;
            Console.WriteLine(op(2, 4));
            OperationDelegate op1 = new OperationDelegate(Multiply);
            Console.WriteLine(op1(2, 4));

            Operation opVoid = Hello;
            opVoid += Sup;
            opVoid();

        }

        public void Hello()
        {
            Console.WriteLine("Hello");
        }

        public void Sup()
        {
            Console.WriteLine("Sup!");
        }

        public float ApplyOperation(float num1, float num2, OperationDelegate op)
        {
            return op(num1, num2);
        }

        public float Add(float num1, float num2)
        {
            return num1+num2;
        }
        public float Substract(float num1, float num2)
        {
            return num1 - num2;
        }

        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}

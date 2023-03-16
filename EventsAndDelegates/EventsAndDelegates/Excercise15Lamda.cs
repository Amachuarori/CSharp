using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class Excercise15Lamda
    {
        static Func<float, float, float> Plus = (x, y) => x + y;
        static Func<float, float, float> Substract = (x, y) => x - y;
        static Func<float, float, float> Multiply = (x, y) => x * y;
        static Func<float, float, float> Divide = (x, y) => x / y;
        Dictionary<string, Func<float, float, float> >operators = new Dictionary<string, Func<float, float, float>>();

        public float OperationGet(string oper, float num1, float num2)
        {
            operators.Add("+", Plus);
            operators.Add("-", Substract);
            operators.Add("*", Multiply);
            operators.Add("/", Divide);

            if (operators.ContainsKey(oper))
            {
                return operators[oper](num1, num2);
                
            }
            else
            {
                return 0;
            }
            

            
        }
    }
}

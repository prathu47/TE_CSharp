using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public delegate void PassDelegateAsParameterDelegate(int a, int b);

    public class Calculator
    {
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Add(int a, int b)
        {
            Console.WriteLine($"{a + b}");//10+20=30
        }
        /// <summary>
        /// Sub
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Sub(int a, int b)
        {
            Console.WriteLine($"{a - b}");
        }
        /// <summary>
        /// Mul
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Mul(int a, int b)
        {
            Console.WriteLine($"{a * b}");
        }
        /// <summary>
        /// Div
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Div(int a, int b)
        {
            Console.WriteLine($"{a / b}");
        }
    }
    internal class PassDelegateAsParameter
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            //reference of the methods are passed as the parameter to the Values method
            Values(calculator.Add, 10, 20);
            Values(calculator.Sub, 20, 10);
            Values(calculator.Mul, 10, 10);
            Values(calculator.Div, 10, 2);


        }
        /// <summary>
        /// delegate as the 1st parameter
        /// </summary>
        /// <param name="dlgt"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Values(PassDelegateAsParameterDelegate dlgt, int a, int b)
        {
            dlgt(a, b);//calculator.Add(10,20)
        }



    }
}
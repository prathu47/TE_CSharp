using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class PassByValueRef
    {
        public static void Main()
        {
            //invoke the swap method
            int a = 10; // 1000 = a = 10
            int b = 20; //1004 = b = 20
            Console.WriteLine($"Before Swap: a:{a},b:{b}");// 10,20
            swap(a, b); //10,20
            Console.WriteLine($"After Swap: a:{a},b:{b}");// 10,20
            Console.WriteLine("--------------------------------------------");
            int x = 100; //x = 1016 = 100
            int y = 200; //y = 1020 = 200
            Console.WriteLine($"Before Swap: x:{x},y:{y}");// 100,200
            swap1(ref x, ref y); //1016,1020
            Console.WriteLine($"After Swap: x:{x},y:{y}");// 200,100


        }
        /// <summary>
        /// Pass by value
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void swap(int num1, int num2) //copy of the values a and b
                                                    //num1 = 1008 = 20 , num2 = 1012 = 10
        {
            Console.WriteLine($"Before Swap: num1:{num1},num2:{num2}");//10,20
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After Swap: num1:{num1},num2:{num2}");//20,10
        }
        /// <summary>
        /// Pass By ref 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        public static void swap1(ref int num1, ref int num2) //address of x and y 
                                                             // x = 1016 = num1 , y = 1020 = num2
        {
            Console.WriteLine($"Before Swap: num1:{num1},num2:{num2}");//100,200
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After Swap: num1:{num1},num2:{num2}");//200,100
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class ParamArray
    {
        public static void Main()
        {
            int total = sum(3, 7, 2, 9, 3, 6, 1, 8);
            Console.WriteLine(total);
            Console.WriteLine("---------------------------------");
            int total1 = sum(3, 7, 2, 9, 1, 8);
            Console.WriteLine(total1);
            Console.WriteLine("---------------------------------");
            int[] n = new int[] { 1, 6, 3, 8, 2, 6, 5 };
            int total2 = sum(n);
            Console.WriteLine(total2);
        }
        /// <summary>
        /// method with the working of params keyword
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum; //return keyword can retutn only one value

        }
    }
}

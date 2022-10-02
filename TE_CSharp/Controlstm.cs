using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// CONTROL STATEMENTS AND TYPES OF METHODS
    /// </summary>
    internal class ControlStmts
    {
        public static void Main()
        {
            Console.WriteLine("CONTROL STATEMENTS");
            //INVOKE STATIC METHOD WITHIN THE SAME CLASS WHERE THE MAIN METHOD IS PRESENT
            Conditional();
            //INVOKE INSTANCE METHOD WITHIN THE SAME CLASS WHERE THE MAIN METHOD IS PRESENT
            ControlStmts c = new ControlStmts(); // instance created for the class
            c.Looping();

        }
        /// <summary>
        /// STATIC METHODS - INVOKED ONCE
        /// </summary>
        public static void Conditional()
        {
            Console.WriteLine("CONTROL STATEMENTS - CONDITIONAL - STATIC");
            //Relational and Logical Operators
            //Greatest of 3 numbers
            int a, b, c;
            Console.WriteLine("Enter the values");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine("A is the greatest");
            }
            else if (b > c)
            {
                Console.WriteLine("B is the greatest");
            }
            else
            {
                Console.WriteLine("C is the greatest");
            }

        }
        /// <summary>
        /// INSTANCE METHOD - no static keyword
        /// </summary>
        public void Looping()
        {
            Console.WriteLine("CONTROL STATEMENTS - LOOPING - INSTANCE");
            //Arrays - 1D Array - Initialize - Compile time
            int[] numbers1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] numbers2 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int[] numbers3 = { 1, 2, 3 };
            int sum = 0;
            Console.WriteLine("----------------------------------------");
            //for loop
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine(numbers1[i]);
            }
            Console.WriteLine("----------------------------------------");
            //foreach
            foreach (int n in numbers2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------");
            //for
            for (int i = 0; i < numbers3.Length; i++)
            {
                sum = sum + numbers3[i];
            }
            Console.WriteLine("Sum is:{0}", sum);
            Console.WriteLine("----------------------------------------");
            //Accept the size and array elements at runtime
            int size;
            Console.WriteLine("Enter the size of the array");
            size = Convert.ToInt32(Console.ReadLine()); //3 
            int[] courseid = new int[size]; //int[] courseid=new int[3]
            //INPUT
            for (int j = 0; j < size; j++) //0<3,1<3,2<3,3<3
            {
                Console.WriteLine("Enter the value of {0} array", (j + 1));
                courseid[j] = Convert.ToInt32(Console.ReadLine()); //course[0]=10,course[1]=20,course[2]=30
            }
            //OUTPUT
            Console.WriteLine("Elements in the Array");
            foreach (int c in courseid)
            {
                Console.WriteLine(c); //10,20,30
            }
        }
    }
}

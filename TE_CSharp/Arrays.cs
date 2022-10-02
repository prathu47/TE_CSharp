using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Arrays
    {
        public static void Main()
        {
            Array_1D();
            Console.WriteLine("------------------------------------------");
            Array_2D();
            Console.WriteLine("------------------------------------------");
            Jagged_Array();
        }
        /// <summary>
        /// 1-D Array and Array functions
        /// </summary>
        public static void Array_1D()
        {
            int[] array = new int[] { 5, 2, 9, 4, 7, 6, 8 };
            Console.WriteLine("1-D Array");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Functions");
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Count());
            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Average());
            Array.Sort(array);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("SORTED ARRAY");//ASC ORDER
            foreach (int j in array)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("SORTED ARRAY IN REVERSE ORDER"); //DESC ORDER
            Array.Reverse(array);
            foreach (int k in array)
            {
                Console.WriteLine(k);
            }

        }
        /// <summary>
        /// 2-D Array
        /// </summary>
        public static void Array_2D()
        {
            //int[rows,columns]
            int[,] array = new int[,]
            {
                //0,1,2,3
                {1,2,3,4}, //array[0]
                {5,6,7,8} //array[1]
            };
            Console.WriteLine("2-D Array");
            //rows
            for (int i = 0; i < array.GetLength(0); i++) // 0<2 1<2 2<2
            {
                //columns
                for (int j = 0; j < array.GetLength(1); j++) //0<4 1<4 2<4 3<4 4<4 
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

        }
        /// <summary>
        /// Array of Arrays
        /// </summary>
        public static void Jagged_Array()
        {
            //int[no of arrays][no of elements]
            int[][] array = new int[][]
            {
                         //0,1,2,3,4
                new int[3]{1,2,3}, //0
                new int[5]{4,5,6,7,8},//1
                new int[2]{9,10}//2
            };
            for (int i = 0; i < array.Length; i++) //0<3 1<3 2<3 3<3
            {
                for (int j = 0; j < array[i].Length; j++)//arry[0]=3 0<3 1<3 2<3 3<3
                                                         //array[1]=5 0<5 1<5 2<5 3<5 4<5 5<5
                                                         //array[2]=2 0<2 1<2 2<2
                {
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }

        }
    }
}

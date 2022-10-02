using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// ARRAYS - Collections of elements under a single datatype
    /// </summary>
    internal class Arrays
    {

        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;

            int row = 2;
            int col = 2;

            int[,] Matrix1 = new int[row, col];
            int[,] Matrix2 = new int[row, col];
            int[,] Matrix3 = new int[row, col];

            Console.WriteLine("Enter the elements of Matrix1: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the elements of Matrix2: ");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Matrix3[i, j] = Matrix1[i, j] + Matrix2[i, j];
                }
            }
            Console.WriteLine("\nMatrix1:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(Matrix1[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix2:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(Matrix2[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("\nAddition of Matrix1 and Matrix2:");
            for (i = 0; i < row; i++)
            {
                for (j = 0; j < col; j++)
                {
                    Console.Write(Matrix3[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }
    }
}

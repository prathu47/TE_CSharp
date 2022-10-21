using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
public class Polymorphism_Overloading
    {
        public static int num;
        /// <summary>
        /// No parameters
        /// </summary>
        public static void add()
        {
            num = 10;
            Console.WriteLine(num);
        }
        /// <summary>
        /// One parameter(int)
        /// </summary>
        /// <param name="a"></param>
        public static void add(int a) //10
        {
            a += a;
            Console.WriteLine(a);
        }
        /// <summary>
        /// one parameter(double)
        /// </summary>
        /// <param name="a"></param>
        public static void add(double a)//12.34
        {
            a += a;
            Console.WriteLine(a);
        }
        /// <summary>
        /// 2 parameters(int,string)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public static void GetDetails(int id,string name)
        {
            Console.WriteLine($"{id}:{name}");
        }
        /// <summary>
        /// 2 parameters(string,int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        public static void GetDetails(string name,int id)
        {
            Console.WriteLine($"{name}:{id}");
        }
        public static void Main()
        {
            add();
            add(10);
            add(12.34);
            GetDetails(10, "John");
            GetDetails("Peter", 102);

        }
    }
}    
    
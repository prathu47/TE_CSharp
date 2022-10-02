using System;  //Namespace - Collection of classes -> collection of functions/methods

/// <summary>
/// user-defined namespace
/// </summary>
namespace Basic_Concepts
{
    /// <summary>
    /// Basic C-Sharp Concepts
    /// </summary>
    class Program
    {
        /// <summary>
        /// entry point ,static - invoked once,void - returns nothing
        /// </summary>
        public static void Main()
        {
            //Console->class, WriteLine->method
            Console.WriteLine("Welcome to C-Sharp");
            //Datatypes
            int a = 20;
            double b = 12.34;
            char c = 'a';
            bool d = true;
            string s = "John";
            //Display the output in various ways
            Console.WriteLine(a);
            //Concatenation
            Console.WriteLine("Double value is:" + b);
            //Index value
            Console.WriteLine("Char value is:{0}", c);
            //Interpolation
            Console.WriteLine($"Hi {s},How are you? There are {a} days remaining for the training to get completed");
            //Multiple index
            Console.WriteLine("I am {0} and my age is {1}", s, a);
            Console.WriteLine("----------------------------------------");

            //Accept input at runtime
            int empid;
            string empname;
            Console.WriteLine("Employee Details");
            Console.WriteLine("Enter the employee id");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the employee name");
            empname = Console.ReadLine();
            Console.WriteLine($"{empname}'s id is: {empid}");
            Console.WriteLine("----------------------------------------");

            //Functions
            //MATH
            Console.WriteLine("MATH FUNCTIONS");
            Console.WriteLine(Math.Round(12.78));
            Console.WriteLine(Math.Floor(12.78));
            Console.WriteLine(Math.Ceiling(12.78));
            Console.WriteLine(Math.Sqrt(4));
            Console.WriteLine(Math.Abs(-12.78));
            Console.WriteLine("----------------------------------------");
            //STRING
            Console.WriteLine("STRING FUNCTIONS");
            string course = "Dotnet Full Stack";
            Console.WriteLine(course.IndexOf("t"));
            Console.WriteLine(course.LastIndexOf("t"));
            Console.WriteLine(course.ToUpper());
            Console.WriteLine(course.Substring(0, 6));
            Console.WriteLine(string.Concat(empname, course));
            //ESCAPE SEQUENCE
            Console.WriteLine("\"Hello\", \'How are you\'");
            //TYPE CONVERSION
            Console.WriteLine("----------------------------------------");
            double num = 12.36;
            int num2 = 65;
            Console.WriteLine(num);
            int num1 = (int)num;
            Console.WriteLine(num1);
            Console.WriteLine(Convert.ToChar(num2));
            Console.WriteLine(Convert.ToInt32('A'));


        }
    }

}
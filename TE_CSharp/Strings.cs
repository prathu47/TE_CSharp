using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Strings
    {
        public static void Main()
        {
            //Invoking the string_demo static method
            string_demo();
            //Invoking the stringbuilder_demo static method
            stringbuilder_demo();
        }
        /// <summary>
        /// STRINGS - IMMUTABLE - CANNOT CHANGE 
        /// </summary>
        public static void string_demo()
        {
            //string -> datatype
            string fname = "Prathusha";
            string lname = "Reddy";
            Console.WriteLine(fname);
            Console.WriteLine(lname);
            //Group of characters - > char array
            char[] name = { 'p', 'a', 'l' };
            //String -> Class
            String s = new String(name);
            string s1 = new string(s);
            Console.WriteLine(s);
            Console.WriteLine(s1);
            //foreach -> access name
            foreach (char n in name)
            {
                Console.Write(n);
            }
            Console.WriteLine("----------------------------------------");
            //Escape sequence - \
            Console.WriteLine("\\\\TE\\\\CSharp");
            //Verbatim Strings - @
            Console.WriteLine(@"\\TE\\CSharp");
            Console.WriteLine("----------------------------------------");

        }
        /// <summary>
        /// STRINGBUILDER -> Class -> Mutable -> System.Text
        /// </summary>
        public static void stringbuilder_demo()
        {
            StringBuilder sb = new StringBuilder("Dotnet"); //Ctrl+. to fix the namespace 
            Console.WriteLine(sb.ToString());
            sb.Append(" Full ");
            Console.WriteLine(sb.ToString());
            sb.Append("Development");
            Console.WriteLine(sb.ToString());
            sb.Insert(12, "Stack ");
            Console.WriteLine(sb.ToString());
            sb.Remove(18, 11);
            Console.WriteLine(sb.ToString());

        }
    }
}
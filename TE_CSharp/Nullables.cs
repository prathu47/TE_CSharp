using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Nullables
    {
        public static void Main()
        {
            int a = 10;
            Console.WriteLine(a);
            //Assigning null value using shorthand operator ?
            int? b = null;
            Console.WriteLine(b);
            //Assigning null value using Nullable Generic class
            Nullable<int> c = null;
            Console.WriteLine("Hello " + c + "  Trainees");
            //Null Coalescing Operator ??
            int? score = null;
            int? defaultscore = 65;
            int? grade;
            grade = score ?? defaultscore;
            Console.WriteLine(grade);

        }
    }
}

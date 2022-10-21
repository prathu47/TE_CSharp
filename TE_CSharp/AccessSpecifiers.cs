using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class AccessSpecifiers
    {
       class ADD
        {
            int x, y;
            double f;
            string s;
            public ADD(int a, double b)
            {
                x = a;
                f = b;
            }

            // 2nd constructor
            public ADD(int a, string b)
            {
                y = a;
                s = b;
            }

            // showing 1st constructor's result
            public void show()
            {
                Console.WriteLine("1st constructor (int + float): {0} ",
                                                               (x + f));
            }
            // shows 2nd constructor's result
            public void show1()
            {
                Console.WriteLine("2nd constructor (int + string): {0}",
                                                               (s + y));
            }
        }

    }
    public class AccessSpecifiersMain
    {
        class GFG
        {
           // Main Method
            static void Main()
            {
                ADD g = new ADD(10, 20.2);
               g.show();
                ADD q = new ADD(10, "Roll No. is ");
               q.show1();
            }
        }
    }

}
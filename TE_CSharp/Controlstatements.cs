
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IntroductionCSharp
{
    internal class NestedIf
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            if (a == 10)
            {
                if (b == 20)
                {
                    Console.WriteLine("Value of a is 10 and b is 20");
                }
                
            }
            Console.ReadLine();
        }
    }
}
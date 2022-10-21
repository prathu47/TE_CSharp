using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Enum_Method_Parameter
    {
        public enum level
        {
            A,
            B,
            C

        }
        public static void bonus_calc(int bonus, level l)
        {

            if ((int)l == 0)
            {
                Console.WriteLine("Bonus : " + 5 * bonus);
            }
            else if ((int)l == 1)
            {
                Console.WriteLine("Bonus : " + 3 * bonus);
            }
            else
            {
                Console.WriteLine("Bonus : " + bonus);

            }

        }
        /// <summary>
        /// enum constants as parameters
        /// </summary>
        public static void Main()
        {
            bonus_calc(10000, level.A);
            bonus_calc(10000, level.B);
            bonus_calc(10000, level.C);
        }
    }
}
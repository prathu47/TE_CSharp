using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class RegExp
    {
        public static void Main()
        {

            mobile();

        }
        public static void mobile()
        {
            Console.WriteLine("mobile validation");
            string mobile = "8795-456-890";
            var validate_mobile = Regex.IsMatch(mobile, @"^\(?([789]{1}[0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$");
            Console.WriteLine(validate_mobile);
        }

    }
}
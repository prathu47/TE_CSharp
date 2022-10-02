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
            email();
            mobile();

        }
        /// <summary>
        /// email validation
        /// </summary>
        public static void email()
        {
            Console.WriteLine("e-mail validation");
            string email_id = "john@gmail.com";
            var validate_email = Regex.IsMatch(email_id, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            Console.WriteLine(validate_email);
        }
        /// <summary>
        /// mobile validation
        /// </summary>
        public static void mobile()
        {
            Console.WriteLine("mobile validation");
            string mobile = "1234-456-8900";
            var validate_mobile = Regex.IsMatch(mobile, @"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            Console.WriteLine(validate_mobile);
        }

    }
}
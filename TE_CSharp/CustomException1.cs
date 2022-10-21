using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class ValidateNameException : Exception
    {
        public ValidateNameException(string message) : base(message)
        {

        }
    }
    /// <summary>
    /// Trainee class - Name property
    /// </summary>
    public class Trainee
    {
        public string Name { get; set; }
    }

    internal class CustomException1
    {
        public static void Main()
        {
            try
            {
                Trainee t_name = new Trainee();
                t_name.Name = "John123";
                ValidateName(t_name);
                Console.WriteLine($"Name:{t_name.Name}");
            }
            catch (ValidateNameException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        /// <summary>
        /// Regular Expression for the Name property
        /// </summary>
        /// <param name="trainee"></param>
        /// <exception cref="ValidateNameException"></exception>
        public static void ValidateName(Trainee trainee) //John123
        {
            Regex regex = new Regex("^[A-Z][a-z]+$");
            if (!regex.IsMatch(trainee.Name)) //John123
                throw new ValidateNameException("Invalid Name");

        }
    }
}
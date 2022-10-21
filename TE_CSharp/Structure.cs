using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    struct EmployeeDetails
    {
        public int empid;
        public string empname;
        /// <summary>
        /// parametrized constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public EmployeeDetails(int id, string name)
        {
            empid = id;
            empname = name;
        }
        /// <summary>
        /// Display the employee details through an instance method
        /// </summary>
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee no {empid} is {empname}");
        }

    }
    internal class Structures
    {
        /// <summary>
        /// Access the employee details from the structure
        /// </summary>
        public static void Main()
        {
            EmployeeDetails empDetails = new EmployeeDetails(13110, "prathusha");
            empDetails.DisplayDetails();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Program
    {
        //private variables
        private int empid;
        private string empname;

        /// <summary>
        /// empid
        /// </summary>
        public int EmployeeID
        {
            get { return empid; }  //read
            set { empid = value; } //write
        }
        /// <summary>
        /// empname
        /// </summary>
        public string EmployeeName
        {
            //get { return empname; }
            set { empname = value; }
        }

        public void Display()
        {
            Console.WriteLine($"{empname}:{empid}");
        }

    }
    internal class Encapsulation
    {
        public static void Main()
        {
            Program program = new Program();
            program.EmployeeID = 100;
            program.EmployeeName = "John";
            Console.WriteLine(program.EmployeeID);
            // Console.WriteLine(program.EmployeeName);
            program.Display();

        }
    }
}
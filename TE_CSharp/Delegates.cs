using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// Created a delegate ->EmpDelegate-> void(return type),2 parameters(int,string)
    /// Signature of the delegate -> match -> Signature of the methods
    /// </summary>
    /// <param name="empid"></param>
    /// <param name="empname"></param>
    public delegate void EmpDelegate(int empid, string empname);
    /// <summary>
    /// Multi-cast delegate working - hold the reference of more than one method
    /// </summary>
    /// <param name="empid"></param>
    /// <param name="empname"></param>
    public delegate void EmpDelegate1(int empid, string empname);

    /// <summary>
    /// Employees - 2 methods
    /// </summary>
    public class Employees
    {
        /// <summary>
        /// GetITLeadDetails
        /// </summary>
        /// <param name="empid"></param>
        /// <param name="empname"></param>
        public void GetITLeadDetails(int empid, string empname)
        {
            Console.WriteLine($"IT: {empid}:{empname}");
        }
        /// <summary>
        /// GetTestingLeadDetails
        /// </summary>
        /// <param name="empid"></param>
        /// <param name="empname"></param>
        public void GetTestingLeadDetails(int empid, string empname)
        {
            Console.WriteLine($"Testing: {empid}:{empname}");
        }
    }
    /// <summary>
    /// Access the methods through delegates
    /// </summary>
    internal class Delegates
    {
        public static void Main()
        {
            //instance for the class
            Employees employees = new Employees();
            //instance for the delegate EmpDelegate
            //Single-cast delegate -> hold only a single reference(one method at a time)
            EmpDelegate empDelegate = employees.GetITLeadDetails; //reference of the GetITLeadDetails()
            empDelegate(100, "John");
            empDelegate = employees.GetTestingLeadDetails;
            empDelegate(201, "Peter");
            //instance for the delegate EmpDelegate1
            //Multi-cast delegate - EmpDelegate1 - 2 references
            EmpDelegate1 empDelegate1 = employees.GetITLeadDetails;
            empDelegate1 += employees.GetTestingLeadDetails;
            Console.WriteLine("TEAM LEAD FOR IT AND TESTING");
            empDelegate1(101, "Sam");
            Console.WriteLine("PROJECT LEAD FOR IT");
            empDelegate1 -= employees.GetTestingLeadDetails;
            empDelegate1(105, "Jancy");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Emp
    {
        protected int eid;
        protected string ename;
        protected void EmpDetails()
        {
            Console.WriteLine("Emp Class");
        }
    }
    /// <summary>
    /// Child class - can access the protected variables - Single
    /// </summary>
    public class ITDept : Emp
    {
        protected int did;
        protected string dname;
        public void DeptDetails()
        {
            EmpDetails();
        }
    }
    /// <summary>
    /// Child class - can access the protected variables - Multi-level
    /// </summary>
    public class Admin : ITDept
    {
        /// <summary>
        /// Assign the values for the eid and ename from Emp class
        /// Assign the values for the did and dname from ITDept class
        /// </summary>
        public void GetDetails()
        {
            eid = 100;
            ename = "John";
            did = 101;
            dname = "IT";
            Console.WriteLine($"{eid}:{ename}:{did}:{dname}");
            EmpDetails();
        }

    }
    /// <summary>
    /// Child class - can access the protected variables - Hybrid,Hierarchial
    /// </summary>

    public class ITStaff : ITDept
    {
        public void Message()
        {
            Console.WriteLine($"{did}:{dname}");
        }
    }

    internal class Inheritance
    {
        public static void Main()
        {
            //Instance for the child class
            //ITDept dept = new ITDept();
            //dept.GetDetails();

            Admin admin = new Admin();
            admin.GetDetails();
            admin.DeptDetails();
            ITStaff iTStaff = new ITStaff();
            iTStaff.Message();

        }
    }
}

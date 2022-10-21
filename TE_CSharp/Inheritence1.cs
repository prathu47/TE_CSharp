using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Bonus1
    {
        protected string name;
        protected int id;
        protected int age;
        protected int salary;
        public Bonus1(string Name, int iid, int aage, int ssalary)
        {
            name = Name;
            id = iid;
            age = aage;
            salary = ssalary;
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public void print()

        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);

        }
    }
    public class Staff : Bonus1
    {
        protected int bonus;
        public Staff(string Name, int id, int age, int salary) : base(Name, id, age, salary)
        {
            base.Name = Name;
            this.id = id;
            this.age = age;
            this.salary = salary;


        }
        public void SPrint()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + (salary * 3));
        }
    }

    public class NonStaff : Bonus1
    {
        protected int bonus;
        public NonStaff(string Name, int id, int age, int salary) : base(Name, id, age, salary)
        {
            base.Name = Name;
            this.id = id;
            this.age = age;
            this.salary = salary;


        }
        public void NSPrint()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + (salary * 3));
        }
    }
    internal class Inheritance1
    {
        public static void Main(string[] args)
        {

            Staff s1 = new Staff("Prathusha", 13109, 22, 30000);
            NonStaff ns1 = new NonStaff("Nikhil", 10199, 25, 25000);
            Console.WriteLine("Staff Details: ");
            s1.SPrint();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("NonStaff Details: ");
            ns1.NSPrint();
        }
    }
}

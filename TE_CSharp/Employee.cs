using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            String[] emplyName = new String[20];
            int[] emplyNo = new int[20];
            String[] emplycourse = new String[20];
            
String[] emplyD = new String[20];
            int n;
            Console.WriteLine("Enter How many Employee data you want to enter");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Name of Employee:");
                emplyName[i] = Console.ReadLine();
                Console.WriteLine("Enter the Emply ID:");
                emplyNo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Stream of Employee:");
                emplycourse[i] = Console.ReadLine();
                Console.WriteLine("Enter the Division of Employee:");
                emplyD[i] = Console.ReadLine();
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Name of the Employee is" + emplyName[j]);
                Console.WriteLine("ID of the Employee is" + emplyNo[j]);
                Console.WriteLine("Stream of the employee is" + emplycourse[j]);
                Console.WriteLine("Division of the employee is" + emplyD[j]);
            }
        }
    }

}


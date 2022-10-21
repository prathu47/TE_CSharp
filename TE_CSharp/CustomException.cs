using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class AttendanceException : ApplicationException
    {
        //Constructor 
        public AttendanceException(string message) : base(message)
        {

        }
    }
    /// <summary>
    /// Step 2:Implementing the exception in the try and catch block
    /// </summary>
    internal class CustomException
    {
        public static void Main()
        {
            int total_trainees;
            try
            {
                Console.WriteLine("Enter the total trainees present");
                total_trainees = Convert.ToInt32(Console.ReadLine());
                if (total_trainees < 38)
                {
                    throw (new AttendanceException("Few are absent"));
                }
                else
                {
                    Console.WriteLine("All are present today");
                }
            }
            catch (AttendanceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
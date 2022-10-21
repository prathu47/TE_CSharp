using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// interface -  ITraining
    /// </summary>
    interface ITraining
    {
        //abstract property
        string Course { get; set; }

        //abstract method
        void CourseDetails();
        void Message();
    }
    /// <summary>
    /// interface - ITrainees
    /// </summary>
    interface ITrainees
    {
        //abstract property
        int Strength { get; set; }
        //abstract method
        void Total_Trainees();
        void Message();
    }
    /// <summary>
    /// CSharp_Training implements(don't use the term inherited) the interface ITraining
    /// </summary>
    public class CSharp_Training : ITraining, ITrainees
    {
        /// <summary>
        /// Property Course implemented from ITraining
        /// </summary> 
        public string Course { get; set; } //C#
        /// <summary>
        /// Property Strength implemented from ITrainees
        /// </summary>
        public int Strength { get; set; } //38
        /// <summary>
        /// CourseDetails implemented from ITraining
        /// </summary>
        public void CourseDetails()
        {
            Console.WriteLine($"Course:{Course}"); //C#
        }
        /// <summary>
        /// Total_Trainees implemented from ITrainees
        /// </summary>
        public void Total_Trainees()
        {
            Console.WriteLine($"Total_Trainees:{Strength}"); //38

        }
        /// <summary>
        /// Message implemented from ITraining
        /// </summary>
        void ITraining.Message()
        {
            Console.WriteLine("ITraining.Message");
        }
        /// <summary>
        /// Message implemented from ITrainees
        /// </summary>
        void ITrainees.Message()
        {
            Console.WriteLine("ITrainees.Message");
        }

    }
    /// <summary>
    /// Working of the Dispose() method - explicit - destructor - memory cleanup of the resources
    /// </summary>
    public class Destructor_Dispose : IDisposable
    {
        /// <summary>
        /// Files(open/close),Database connection(open/close),services
        /// </summary>
        public void Dispose()
        {
            Console.WriteLine("Dispose:Memory cleanup done");

        }
    }
    internal class Interface
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            CSharp_Training cSharp_Training = new CSharp_Training();
            cSharp_Training.Course = "C#";
            cSharp_Training.CourseDetails();
            cSharp_Training.Strength = 38;
            cSharp_Training.Total_Trainees();
            //Base->Derived
            ITraining training = new CSharp_Training();
            training.Message();
            ITrainees trainees = new CSharp_Training();
            trainees.Message();
            Destructor_Dispose destructor_Dispose = new Destructor_Dispose();
            destructor_Dispose.Dispose();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    class ClassTest

    {

        //Public method

        public void MethodPublic()

        {

            // defination of MethodPublic

        }

    }

    // to access the method

    class Program1

    {

        static void Main(string[] args)

        {

            ClassTest objClassTest = new ClassTest();
            objClassTest.MethodPublic(); // valid code to access.

        }

    }
}
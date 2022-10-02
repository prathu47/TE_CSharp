using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TE_CSharp
{
    public class Multiplication
    {
        void Method(out int sid, out string sname, out string sdep)
        {
            sid = 10;
            sname = "Bindu";
            sdep = "cse";
        }

        int sid;
        string sname, sdep;
        Method(out sid, out sname, out sdep);
        Console.WriteLine(sid);
        Console.WriteLine(sname);
        Console.WriteLine(sdep);

       
}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class externalclasslibrary
    {
        static void Main(string[] args)
        {
            cl_class2 ob = new cl_class2();
            int t = ob.print();
            int te = ob.print1();
            Console.WriteLine("print {0} print1{1}", t, te);

        }
    }
}

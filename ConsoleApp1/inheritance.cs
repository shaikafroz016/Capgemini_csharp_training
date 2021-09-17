using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    class a 
    {
        public int x = 10;
        public void pr()
        {
            Console.WriteLine("Inside a class {0}", x);
        }
    }
    class b : a
    {
        public void pr1()
        {
            Console.WriteLine("Inside b class {0}", x);
        }
    }
    class inheritance
    {
        static void Main(string[] args)
        {
            b ob = new b();
            ob.pr1();
        }
    }
}

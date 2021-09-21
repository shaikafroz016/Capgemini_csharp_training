using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   public interface calc//interface means once declared methods sould be defined in inherited class
    {
        int add(int a, int b);
        int sub(int a, int b);
        int mul(int a, int b);
    }
    class cl : calc
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
    }
    class interfacewithpoly
    {
        static void Main(string[] args)
        {
            cl ob = new cl();
            Console.WriteLine(ob.add(10, 20));
            Console.WriteLine(ob.sub(10, 20));
            Console.WriteLine(ob.mul(10, 20));
        }
    }
}

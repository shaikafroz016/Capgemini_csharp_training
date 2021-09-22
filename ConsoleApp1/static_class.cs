using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    static class s_class//static means without creating object.it is also used as global operation that combibiend for all
    {
        static int x = 0;
        public static int inc()
        {
            x++;
            return x;
        }
    }
    class o_class
    {   
        public void print()
        {
            int z = s_class.inc();//insted of object using class name and can be access
            Console.WriteLine(z);
        }
    }

    class static_class
    {
        static void Main(string[] args)
        {
            o_class ob = new o_class();
            ob.print();
            ob.print();
        }
    }
}

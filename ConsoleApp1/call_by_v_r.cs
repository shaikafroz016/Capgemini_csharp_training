using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sks
    {
        public void call_by_val(int a,int b)
        {
            a = 20;
            b = 30;
        }
        public void call_by_ref(ref int a, ref int b)
        {
            a = 20;
            b = 30;
        }
    }
    class call_by_v_r
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("before {0} {1}", a, b);
            sks ob = new sks();
            ob.call_by_val(a, b);
            ob.call_by_ref(ref a, ref b);
            Console.WriteLine("after {0} {1}", a, b);
            Console.WriteLine((float)a/3);
            
        }
    }
}

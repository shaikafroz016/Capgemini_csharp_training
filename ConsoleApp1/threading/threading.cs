using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1.threading
{
    class threading
    {   class t_class
        {
            public void method1()
            {
                for(int t = 0; t < 10; t++)
                {
                    Console.WriteLine("method1={0} thread name={1}", t,Thread.CurrentThread.Name);
                }
            }
            public void method2()
            {
                for (int t = 0; t < 10; t++)
                {
                    Console.WriteLine("method2={0} thread name={1}", t, Thread.CurrentThread.Name);
                }
            }
            public void method3()
            {
                for (int t = 0; t < 10; t++)
                {
                    Console.WriteLine("method3 {0}", t);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main methode");
            t_class th = new t_class();
            Thread t = new Thread(th.method1);
            Thread te = new Thread(th.method2);
            Thread tem = new Thread(th.method3);
            t.Start();
            t.Name = "thread1";
            te.Start();
            te.Name = "thread2";
            tem.Start();
        }
    }
}

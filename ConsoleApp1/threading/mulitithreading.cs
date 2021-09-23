using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp1.threading
{   class m_thrd
    {
        public void webserver()
      
        {
            lock (this)//locking to maintain sync between users when all are requesting to same
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("recourse{0} username{1}", i, Thread.CurrentThread.Name);
                }
            }
            
        }
    }
    class mulitithreading
    {
        static void Main(string[] args)
        {
            m_thrd mt = new m_thrd();
            Thread user1 = new Thread(mt.webserver);
            Thread user2 = new Thread(mt.webserver);
            Thread user3 = new Thread(mt.webserver);
            Thread user4 = new Thread(mt.webserver);
            user1.Name = "shaik";
            user2.Name = "sho";
            user3.Name = "afn";
            user4.Name = "soh";
            user1.Start();
            user2.Start();
            user3.Start();
            user4.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{   class itretor
    {
        public void print(IEnumerable ar)//IEnumerable can recive any type of array,arraylist,list
        {
            IEnumerator ir = ar.GetEnumerator();//getenumerator convert the recived array,arraylist,list into numerator dynamically
            while (ir.MoveNext())
            {
                Console.WriteLine(ir.Current);
            }
        }   
    }
    class ienumerator_inmerable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("printing arraylist");
            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add("shaik");
            al.Add(6.0908);
            itretor it = new itretor();
            it.print(al);//by passing array list
            Console.WriteLine("printing list");
            List<int> li = new List<int>();
            li.Add(123);
            li.Add(23);
            li.Add(324);
            it.print(li);//by passing list
            Console.WriteLine("printing array");
            string[] arry = new string[3];
            arry[0] = "sks";
            arry[1] = "vss";
            it.print(arry);//by passing array
            //stack and queue

            Stack st = new Stack();
            for (int i = 0; i < 4; i++)
            {
                st.Push(i * 10);
            }
            foreach (int x in st)
            {
                Console.WriteLine(x);
            }
            Queue qe = new Queue();
            for (int i = 0; i < 5; i++)
            {
                qe.Enqueue(i * 20);
            }
            foreach (int x in qe)
            {
                Console.WriteLine(x);
            }
        }
    }
}

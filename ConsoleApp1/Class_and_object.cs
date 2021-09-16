using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class cap { 
        //public void hello()
        //{
        //    Console.Write("inside hello methode");
        //}    

        //public int add(int a,int b)
        //{
        //    return a + b;
        //}

        //passing array
        /*public int[] addarray(int[] a,int[] b)
        {
            int[] res = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                res[i] = a[i] + b[i];
            }
            return res;
        }*/

        //adding two arays with two  return's

        public void sumarray(int[] a,int[] b,out int sum,out int sum1)
        {
            int s= 0;
            int s1 = 0;
            for(int i = 0; i < a.Length; i++)
            {
                s =s+ a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                s1 = s1 + b[i];
            }
            sum = s;
            sum1 = s1;
        }
    }

    class Class_and_object
    {
        static void Main(string[] args)
        {
            //cap ob = new cap();
            //int c=ob.add(5,6);
            //Console.WriteLine(c);
            Console.WriteLine("Enter size of the aarray");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            int[] b = new int[size];
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine("enter 1st array values");
                    a[j] = int.Parse(Console.ReadLine());
                }
            for (int j = 0; j < size; j++)
            {
                Console.WriteLine("enter 2nd array values");
                b[j] = int.Parse(Console.ReadLine());
            }

            cap ob = new cap();
            /*int[] res = ob.addarray(a, b);
            for(int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]);
            }*/
            int sum, sum1;
            ob.sumarray(a, b, out sum, out sum1);
            Console.WriteLine("the sum of a array is {0} sum of b array is {1} ", sum,sum1);


        }
    }
}

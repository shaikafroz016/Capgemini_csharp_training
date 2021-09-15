using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class one_d_array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            //arr[0] = 121;
            //arr[2] = 131;
            //reading array
            Console.WriteLine("Enter array values");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter array {0} value", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            //printing values
            Console.WriteLine("printing values");
            foreach(int x in arr)
            {
                Console.WriteLine(x);
            }

            //sum
            int sum = 0;
            Console.WriteLine("Addition of all values");
            foreach (int x in arr) 
            {
                sum += x;
            }
            Console.WriteLine("\t" + sum);

            //searching
            Console.WriteLine("Searching");
            int ser = int.Parse(Console.ReadLine());
            bool b = false;
            foreach (int x in arr)
            {
                if (ser == x)
                {
                    b = true;
                    Console.WriteLine("Found");
                }
            }
            if (b == false)
            {
                Console.WriteLine("Not found");
            }
        }
    }
}

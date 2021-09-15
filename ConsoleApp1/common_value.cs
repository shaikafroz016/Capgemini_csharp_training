using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class common_value
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int[] arr1 = new int[3];
            //arr[0] = 121;
            //arr[2] = 131;
            //reading array
            Console.WriteLine("Enter first array values");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter array({0}) value", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter array2 values");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter array {0} value", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            int common = 0;
            foreach (int x in arr)
            {
                foreach (int y in arr1)
                {
                    if (x == y)
                    {
                        common = y;
                    }
                }
            }
            if (common == 0)
            {
                Console.WriteLine("No common items found");
            }
            else
            {
                Console.WriteLine("Common item is {0}", common);
            }
        }
    }
}

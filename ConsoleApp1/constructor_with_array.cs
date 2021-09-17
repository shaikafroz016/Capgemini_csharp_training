using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class cll
    {
        public int[] arr;
        public cll(int[] arr)
        {
            this.arr = arr;
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
    class constructor_with_array
    {
        static void Main(string[] args)
        { 
            int[] arr = new int[5];
            arr[0] = 121;
            arr[2] = 131;
            cll ob = new cll(arr);
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class jagged_array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of row");
            int row = int.Parse(Console.ReadLine());
            int[][] j_array = new int[row][];
            for (int i = 0; i < j_array.Length; i++)
            {
                Console.WriteLine("enter {0} jagged array size",i+1);
                int size = int.Parse(Console.ReadLine());
                int[] temp = new int[size];
                for (int k = 0; k < size; k++)
                {
                    Console.WriteLine("enter jagged arry({0}) element",k);
                    int t = int.Parse(Console.ReadLine());
                    temp[k] = t;
                }
                j_array[i] = temp;
            }
            for (int i = 0; i < j_array.Length; i++)
            {
                Console.WriteLine("array index {0}", i);
                for (int j = 0; j < j_array[i].Length; j++)
                {
                    Console.Write("\t" + j_array[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

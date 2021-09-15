using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class addition
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3 = new int[3, 3];
            Console.WriteLine("Enter arr1 values");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter arr2 values");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("printing two matix\n");
            for (int i = 0; i < 3; i++)
            {   
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + arr1[i, j]);
                }
                Console.WriteLine(); 
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + arr2[i, j]);
                }
                Console.WriteLine();

            }
            Console.WriteLine("Addition of two matrix \n");
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("Printing 3rd matrix\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + arr3[i, j]);
                }
                Console.WriteLine();

            }
        }
    }
}

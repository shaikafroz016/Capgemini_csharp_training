using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class two_d_arry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows and cols \n");
            int row, col;
            row=int.Parse(Console.ReadLine());
            col = int.Parse(Console.ReadLine());
            int[,] arr = new int[row, col];
            Console.WriteLine("Enter values");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {   //assesment
                int sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum = sum + arr[i,j];
                    Console.Write("\t" + arr[i, j]);
                }
                Console.WriteLine("\t sum={0}",sum);
                
            }
        }
    }
}

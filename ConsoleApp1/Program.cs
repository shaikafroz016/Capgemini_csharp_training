using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int empsal, empnu;
            string name;
            Console.WriteLine("ENTER details");
            Console.WriteLine("enter empsal");
            empsal = int.Parse(Console.ReadLine());
            Console.WriteLine("enter empnumber");
            empnu = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("emp={0} empnu={1} name{2}", empsal, empnu, name);
            //ELse if staements
            if (empsal >60000 && empsal < 65000)
            {
                Console.WriteLine("empsal is {0} inside if state ment", empsal);
            }
            else if (empsal >40000 && empsal <= 50000)
            {
                Console.WriteLine("empsal is {0} inside else if statement", empsal);
            }

            //loops
            //for loop
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Inside the for loop, the i value is {0}", i);
            }

            //while loop
            int w = 1;
            while(w<5)
            {
                Console.WriteLine("inside while loop w={0}", w);
                w++;
            }

            //do while
            int dow = 1;
            do
            {
                
                Console.WriteLine("Inside do while dow = {0}", dow);
                dow++;
            } while (dow < 5);

            //nested forloop
            Console.WriteLine("Inside nested for loop");
            for (int i = 0;i<5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    
                    Console.Write("\t" + j);
                }
                Console.WriteLine();
            }

            //nested while same as nestef for
            // switch
            Console.WriteLine("Enter numbers from 1 to 3");
            int sw = int.Parse(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default: Console.WriteLine("enter correct option");
                    break;
            }

        }
    }
}

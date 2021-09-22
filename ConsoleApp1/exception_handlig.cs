using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class excep_in_class
    {
        public int print()
        {
            Console.WriteLine("Enter x,y values");
           int x= int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            try
            {
                int z = x / y;
                return z;
            }
            catch
            {
                throw;
            }

        }
    }
    class exception_handlig
    {
        static void Main(string[] args)
        {
            try// a try block can contain multiple catch block
            {
                Console.WriteLine("enter size of array");
                int size = int.Parse(Console.ReadLine());
                int[] a = new int[size];
                for (int i = 0; i < 4; i++)
                {
                a[i]=int.Parse(Console.ReadLine());
                }
                int z = 10 / a[0];
            }
            
            catch (IndexOutOfRangeException ex)
            {
                
                Console.WriteLine("exception occuerd {0}", ex.Message.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Eception occured {0}", ex.Message.ToString());
                
                
            }
            excep_in_class ec = new excep_in_class();
            try
            {
                int z=ec.print();
                Console.WriteLine(z);
            }
            catch (DivideByZeroException ep)
            {
                Console.WriteLine("Error" + ep.Message.ToString());
            }

        }
    }
}

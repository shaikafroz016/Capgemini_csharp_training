using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Structure
    {
        public struct product
        {
            public int prod_id;
            public string prod_name;
            public int prod_price;
        }
        static void Main(string[] args)
        {
            product[] p = new product[3];
            for (int i = 0; i < 3; i++) { 
            Console.WriteLine("Enter Product id");
            p[i].prod_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product name");
            p[i].prod_name = Console.ReadLine();
            Console.WriteLine("Enter Product price");
            p[i].prod_price = int.Parse(Console.ReadLine());
        }
            for (int i = 0; i < p.Length; i++)
            {

                Console.WriteLine("product id = {0} product name = {1} price = {2} ", p[i].prod_id, p[i].prod_name, p[i].prod_price);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct product1
    {
        public int p_id;
        public string p_name;
        public int price;
    }
    class calculator
    {

        public product1[] netprice(product1[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].price > 10000)
                {
                    p[i].price = p[i].price - (p[i].price * 10 / 100);
                }
            }
            return p;
        }
    }
    class product_array
    {

        static void Main(string[] args)
        {
            product1[] p = new product1[3];
            for (int i = 0; i < p.Length; i++)
            {

                Console.WriteLine("Product id");
                p[i].p_id = int.Parse(Console.ReadLine());

                Console.WriteLine("Product Name");
                p[i].p_name = Console.ReadLine();

                Console.WriteLine("Price");
                p[i].price = int.Parse(Console.ReadLine());
            }
            calculator calc = new calculator();
            product1[] p1 = calc.netprice(p);

            Console.WriteLine("after discount");

            for (int i = 0; i < p1.Length; i++)
            {

                Console.WriteLine("product id = {0} product name = {1} price = {2} ", p1[i].p_id, p1[i].p_name, p1[i].price);
            }
        }
    }
}

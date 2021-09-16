using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct product
    {
        public int prod_id;
        public string prod_name;
        public int prod_price;
    }
    class cls
    {
        public int Serch_p(product[] p, int k)
        {
            
            int d =-1;
            for(int i = 0; i < p.Length; i++)
            {
                if (k==p[i].prod_id)
                {
                    return i;
                    
                }
            }
            return d;
        }
    }
    class assessment_on_class_obj
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the product array");
            int size = int.Parse(Console.ReadLine());
            product[] p = new product[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter {0} product details", i + 1);
                Console.WriteLine("Enter Product id");
                p[i].prod_id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product name");
                p[i].prod_name = Console.ReadLine();
                Console.WriteLine("Enter Product price");
                p[i].prod_price = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter search value");
            int key = int.Parse(Console.ReadLine());
            cls ob = new cls();
            int id;
            
             id=ob.Serch_p(p, key);
            if (id >=0)
            {
                Console.WriteLine("product id is {0} name is {1} price is {2}", p[id].prod_id, p[id].prod_name, p[id].prod_price);
            }
            else
            {
                Console.WriteLine("product id={0} is not in list",key);
            }
        }
    }
}

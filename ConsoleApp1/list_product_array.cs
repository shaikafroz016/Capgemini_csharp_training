using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class sk
    {
        List<product0> li = new List<product0>();
        public sk(List<product0> li)
        {
            this.li = li;
        }
        public void print()
        {
            foreach (product0 x in li)
            {
                Console.WriteLine("id {0}", x.p_id);
            }
        }
    }
    class list_product_array
    {   
        static void Main(string[] args)
        {
            List<product0> li = new List<product0>();
            //List<int> li = new List<int>();
            //for (int i = 0; i < 9; i++)
            //{
            //    li.Add(i + 1);
            //}
            int id, pri,ch;
            string nme;
            //we are using do while to achive dynamic length compare to for loop in which we have to in fixed length
            do
            {
                Console.WriteLine("Enter product id");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter product price");
                pri = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter product name");
                nme = Console.ReadLine();
                li.Add(new product0 { p_id = id, p_name = nme, p_price = pri });
                Console.WriteLine("Contue or exit 0 or 1");
                 ch = int.Parse(Console.ReadLine());

            } while (ch == 1);
            sk ob = new sk(li);
            ob.print();
        }
    }
}

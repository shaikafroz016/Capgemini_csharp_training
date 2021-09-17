using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//getter setter class or modal or entity
namespace ConsoleApp1
{   class product0
    {
        public int p_id { get; set; }
        public string p_name { get; set; }
        public int p_price { get; set; }

    }
    class getter_setter
    {
        static void Main(string[] args)
        {
           // product0 ob = new product0();
            //ob.p_id = int.Parse(Console.ReadLine());
            //ob.p_name = Console.ReadLine();
            //ob.p_price = int.Parse(Console.ReadLine());
            //Console.WriteLine(ob.p_id);
            //Console.WriteLine(ob.p_name);
            //Console.WriteLine(ob.p_price);
            //storing as a array
            product0[] arr = new product0[3];
            //arr[0] = new product0 { p_id = 100, p_name = "sks", p_price = 345 };
            //arr[1] = new product0 { p_id = 100, p_name = "sks", p_price = 345 };
            //arr[2] = new product0 { p_id = 100, p_name = "sks", p_price = 345 };
            //reading at runtime
            for (int i = 0; i < arr.Length; i++)
            {
                int id, pri;
                string nme;
                Console.WriteLine("enter values of id ");
                id= int.Parse(Console.ReadLine());
                Console.WriteLine("enter values of name");
                nme = Console.ReadLine();
                Console.WriteLine("enter values of price");
                pri = int.Parse(Console.ReadLine());
                arr[i] = new product0 { p_id = id, p_name = nme, p_price = pri };
            }
            
            foreach (product0 x in arr)
            {
                Console.WriteLine("id={0} name={1} price={2}", x.p_id, x.p_name, x.p_price);
            }
                    
            }
        }
    
}

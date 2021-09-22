using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class dict_collection
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            Console.WriteLine("enter key");

            int i = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int z= i; z < n; z++)
            {
                Console.WriteLine("Enter str valur");
                string sk = Console.ReadLine();
                dt.Add(z, sk);
            }
            foreach(KeyValuePair<int,string> x in dt)
            {
                Console.WriteLine(x);
            }
        }
    }
}

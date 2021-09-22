using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bkg_list
    {
        public void print(Dictionary<string, List<banking>> di)
        {
            foreach (KeyValuePair<string, List<banking>> x in di)
            {
                Console.WriteLine(" -----------department {0}----------------", x.Key);
                foreach (banking x1 in x.Value)
                {
                    Console.WriteLine("name = {0} phone = {1} address = {2}", x1.name, x1.phone, x1.address);
                }

            }

        }
    }
    class jagged_dict
    {   
        static void Main(string[] args)
        {
            List<banking> s_acc = new List<banking>();
            List<banking> c_acc = new List<banking>();
            List<banking> n_acc = new List<banking>();
            void  s_accreading()
        {
                int k1 = 0;
                do
                {
                    Console.WriteLine("enter name,address,phone number of saving acc");
                    string name1 = Console.ReadLine();
                    string add = Console.ReadLine();
                    long ph = long.Parse(Console.ReadLine());
                    s_acc.Add(new banking { name = name1, address = add, phone = ph });
                    Console.WriteLine("1-contenue or 0-exit");
                    k1 = int.Parse(Console.ReadLine());
                } while (k1 == 1);
        }
            void co_accread()
            {
                int k1 = 0;
                do
                {
                    Console.WriteLine("enter name,address,phone number of corp acc");
                    string name1 = Console.ReadLine();
                    string add = Console.ReadLine();
                    long ph = long.Parse(Console.ReadLine());
                    c_acc.Add(new banking { name = name1, address = add, phone = ph });
                    Console.WriteLine("1-contenue or 0-exit");
                    k1 = int.Parse(Console.ReadLine());
                } while (k1 == 1);
            }

            void nri_accread()
            {
                int k1 = 0;
                do
                {
                    Console.WriteLine("enter name,address,phone number of nri acc");
                    string name1 = Console.ReadLine();
                    string add = Console.ReadLine();
                    long ph = long.Parse(Console.ReadLine());
                    n_acc.Add(new banking { name = name1, address = add, phone = ph });
                    Console.WriteLine("1-contenue or 0-exit");
                    k1 = int.Parse(Console.ReadLine());
                } while (k1 == 1);
            }

            s_accreading();
            co_accread();
            nri_accread();
            Dictionary<string, List<banking>> adl = new Dictionary<string, List<banking>>();
            adl.Add("saving", s_acc);
            adl.Add("Corp", c_acc);
            adl.Add("NRI", n_acc);
            bkg_list bg = new bkg_list();
            bg.print(adl);
        }
    }
}

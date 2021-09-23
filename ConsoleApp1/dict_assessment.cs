using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class players
    {
        public int pl_id { get; set; }
        public string pl_name { get; set; }
        public string catgame { get; set; }
        public string country { get; set; }
    }
    class players_list
    {
        public void print(Dictionary<string, List<players>> di)
        {
            foreach (KeyValuePair<string, List<players>> x in di)
            {
                Console.WriteLine(" -----------category {0}----------------", x.Key);
                foreach (players x1 in x.Value)
                {
                    Console.WriteLine("name = {0} player id = {1} country = {2}", x1.pl_name, x1.pl_id, x1.country);
                }
                Console.WriteLine("\n");

            }

        }
    }
    class pl_list
    {
        public Dictionary<string, List<players>> list_players(List<players> ls)
        {
            Dictionary<string, List<players>> di = new Dictionary<string, List<players>>();
            List<players> ls1 = new List<players>();
            List<players> ls2 = new List<players>();
            List<players> ls3 = new List<players>();
            foreach (players x in ls)
            {
                if (x.catgame == "cricket")
                {
                    ls1.Add(new players { pl_name = x.pl_name, pl_id = x.pl_id, catgame = x.catgame, country = x.country });
                }
                else if (x.catgame == "hockey")
                {
                    ls2.Add(new players { pl_name = x.pl_name, pl_id = x.pl_id, catgame = x.catgame, country = x.country });

                }
                else if (x.catgame == "football")
                {
                    ls3.Add(new players { pl_name = x.pl_name, pl_id = x.pl_id, catgame = x.catgame, country = x.country });
                }

            }
            di.Add("cricket", ls1);
            di.Add("hockey", ls2);
            di.Add("football", ls3);

            return di;

        }
    }
    class dict_assessment
    {
        static void Main(string[] args)
        {
            List<players> li = new List<players>();
            void plreading()
            {
                int key = 0;
                do
                {
                    Console.WriteLine("ENter plid,plname,catgame,country");
                    int id = int.Parse(Console.ReadLine());
                    string name = Console.ReadLine();
                    string catg = Console.ReadLine();
                    string county = Console.ReadLine();
                    li.Add(new players { pl_id = id, pl_name = name, catgame = catg, country = county });
                    Console.WriteLine("1-cotenue or 0-exit");
                    key = int.Parse(Console.ReadLine());
                } while (key == 1);

            }
            plreading();
            Dictionary<string, List<players>> pl_li = new Dictionary<string, List<players>>();
            pl_list so_dict = new pl_list();
            pl_li = so_dict.list_players(li);
            players_list lidic = new players_list();
            lidic.print(pl_li);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;

namespace ConsoleApp1.file_handlng
{
    class assmnt_serial_deserial
    {   [Serializable]
        class p_list 
        {
            List<players> li = new List<players>();
            public void read_players()
            {
                int k = 0;
                do
                {
                    players p = new players();
                    Console.WriteLine("ENter plid,plname,catgame,country");
                    p.pl_id = int.Parse(Console.ReadLine());
                    p.pl_name = Console.ReadLine();
                    p.catgame = Console.ReadLine();
                    p.country = Console.ReadLine();
                    li.Add(p);
                    Console.WriteLine("1-cotenue or 0-exit");
                    k = int.Parse(Console.ReadLine());
                } while (k == 1);
            }
            public void serial()
            {
                StreamWriter sw = new StreamWriter("e://CG//playersinfo.txt");
                sw.Write("Players details");
                foreach (players x in li)
                {
                    Console.WriteLine("name={0}", x.pl_name);
                    Console.WriteLine("id={0}", x.pl_id);
                    Console.WriteLine("Country=" + x.country);
                    Console.WriteLine("categeory=" + x.catgame);
                    Console.WriteLine("\n");
                    sw.WriteLine("name={0}", x.pl_name);
                    sw.WriteLine("id={0}", x.pl_id);
                    sw.WriteLine("Country=" + x.country);
                    sw.WriteLine("categeory=" + x.catgame);
                }
                sw.Close();
                Console.WriteLine("serializtion started");
                FileStream fs = new FileStream("e://CG//playersinfo.data", FileMode.Create);
                BinaryFormatter btr = new BinaryFormatter();
                foreach (players x in li)
                {
                    btr.Serialize(fs, x);
                }
                Console.WriteLine("Serializition completed");
                fs.Close();
                FileStream fs1 = new FileStream("e://CG//playersinfo.data", FileMode.Open);
               List<players> lis = (List<players>)btr.Deserialize(fs1);
                Console.WriteLine("Printing after deserializtion");
                foreach (players x in lis)
                {
                    Console.WriteLine("name={0}", x.pl_name);
                    Console.WriteLine("id={0}", x.pl_id);
                    Console.WriteLine("Country=" + x.country);
                    Console.WriteLine("categeory=" + x.catgame);
                }
                fs1.Close();
            }
        }
        
        static void Main(string[] args)
        {
            p_list p_l = new p_list();
            p_l.read_players();
            p_l.serial();
            
        }
    }
}

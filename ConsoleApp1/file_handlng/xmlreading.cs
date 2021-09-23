using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1.file_handlng
{
    class xmlreading
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("e://CG//empxml.xml");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine("emp name={0}", ds.Tables[0].Rows[i].ItemArray[0]);
                Console.WriteLine("emp dept={0}", ds.Tables[0].Rows[i].ItemArray[1]);
                Console.WriteLine("emp job={0}", ds.Tables[0].Rows[i].ItemArray[2]);
                Console.WriteLine("emp salary={0}", ds.Tables[0].Rows[i].ItemArray[3]);
                Console.WriteLine("emp no={0}", ds.Tables[0].Rows[i].ItemArray[4]);
                Console.WriteLine("\n");
            }
            FileStream fs = new FileStream("e://CG//empdata.data", FileMode.Create);
            BinaryFormatter btr = new BinaryFormatter();//used for serialzie or deserialzise
            btr.Serialize(fs, ds);
            fs.Close();
            Console.WriteLine("Serialize successfull");
            FileStream fs1 = new FileStream("e://CG//empdata.data", FileMode.Open);
            DataSet ds1 = (DataSet)btr.Deserialize(fs1);
            for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine("emp name={0}", ds1.Tables[0].Rows[i].ItemArray[0]);
                Console.WriteLine("emp dept={0}", ds1.Tables[0].Rows[i].ItemArray[1]);
                Console.WriteLine("emp job={0}", ds1.Tables[0].Rows[i].ItemArray[2]);
                Console.WriteLine("emp salary={0}", ds1.Tables[0].Rows[i].ItemArray[3]);
                Console.WriteLine("emp no={0}", ds1.Tables[0].Rows[i].ItemArray[4]);
                Console.WriteLine("\n");
            }
            fs1.Close();
            players p = new players();
            p.catgame = "footbaal";
            p.country = "india";
            p.pl_id = 454514;
            p.pl_name = "sks";
            StreamWriter txt = new StreamWriter("e://CG//players.xml");
            XmlSerializer xsl = new XmlSerializer(typeof(players));
            xsl.Serialize(txt, p);
            txt.Close();
            StreamWriter sw = new StreamWriter("e://CG//players.txt");
            sw.WriteLine(p.catgame,p.country);
            sw.Flush();
            sw.Close();
            
        }
    }
}

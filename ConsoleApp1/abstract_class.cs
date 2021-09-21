using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   abstract class d_connect
    {   //in abstract we can use constructor,constructor chaning, variable declaration etc but not interface
        string ip, d_name;
        public d_connect(string ip,string d_name)
        {
            this.ip = ip;
            this.d_name = d_name;
        }
        public void connection()
        {
            Console.WriteLine("connecting to server with ip={0} and domain name={1}", ip, d_name);
        }
        public abstract void db_connect();
        public abstract void credential();
        public abstract void objectconnect();

    }
    class  oracal_conn : d_connect
    {
        string ip, d_name;
        public oracal_conn(string ip,string d_name) : base(ip, d_name)//cunstructor chaning
        {
            this.ip = ip;
            this.d_name = d_name;
        }
        public override void db_connect()
        {
            Console.WriteLine("Db connection");

        }
        public override void credential()
        {
            Console.WriteLine("Login credential");
        }
        public override void objectconnect()
        {
            Console.WriteLine("connecting object");
        }
    }
    class sql_conn : d_connect
    {
        string ip, d_name;
        public sql_conn(string ip,string d_name) : base(ip, d_name)
        {
            this.ip = ip;
            this.d_name = d_name;
        }
        public override void db_connect()
        {
            Console.WriteLine("sql connection");

        }
        public override void credential()
        {
            Console.WriteLine("Login credential");
        }
        public override void objectconnect()
        {
            Console.WriteLine("connecting object");
        }
    }
    class mysql_conn : d_connect
    {
        string ip, d_name;
        public mysql_conn(string ip, string d_name) : base(ip, d_name)
        {
            this.ip = ip;
            this.d_name = d_name;
        }
        public override void db_connect()
        {
            Console.WriteLine("mysql connection");

        }
        public override void credential()
        {
            Console.WriteLine("Login credential");
        }
        public override void objectconnect()
        {
            Console.WriteLine("connecting object");
        }
    }
    class abstract_class
    {
        static void Main(string[] args)
        {
            int k = 0;
            do
            {
                Console.WriteLine("1-oracal-connection");
                Console.WriteLine("2-sql connection");
                Console.WriteLine("3-my sql");
                int ver = int.Parse(Console.ReadLine());
                d_connect obj = null;//pointer to store the address of abstract class
                if (ver == 1)
                {
                    obj = new oracal_conn("192.168.0.1","sks");
                    obj.connection();
                    obj.db_connect();
                    obj.credential();
                    obj.objectconnect();
                }
                else if (ver == 2)
                {
                    obj = new sql_conn("0.0.0.0","vss");
                    obj.connection();
                    obj.db_connect();
                    obj.credential();
                    obj.objectconnect();
                }
                else if (ver == 3)
                {
                    obj = new mysql_conn("1.1.1.1","awm");
                    obj.connection();
                    obj.db_connect();
                    obj.credential();
                    obj.objectconnect();
                }
                Console.WriteLine("1-contebue or 0-exit");
                k = int.Parse(Console.ReadLine());
            } while (k == 1);
        }
    }
}

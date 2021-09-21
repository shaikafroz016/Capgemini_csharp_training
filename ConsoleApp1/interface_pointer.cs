using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    class banking
    {
         public string name { get; set; }
        public string address { get; set; }
        public long  phone { get; set; }
    }

    public interface bank
    {
        void openaccount();
        void deposite();
        void withdraw();
        void closeac();

    }
     class read:banking
     {
        public banking reading()
        {   
            banking bc = new banking();
            Console.WriteLine("ENter name,address,phone number");
            bc.name = Console.ReadLine();
            bc.address = Console.ReadLine();
            bc.phone = long.Parse(Console.ReadLine());
            return bc;
        }
     }
    
    class savingacc : read,bank//read class as a hybrid inheritance
    {
        int depost;
        string nominee;
        public void openaccount()
        {
            banking b=reading();
            Console.WriteLine("Enter deposite amount,nominee");
            depost = int.Parse(Console.ReadLine());
            nominee = Console.ReadLine();
            Console.WriteLine("Account created with the name {0} with deposite amount{1}", b.name,depost);
        }
        public void deposite()
        {

        }
        public void withdraw()
        {

        }
        public void closeac()
        {

        }
    }
    class corpacc : bank
    {
        string c_reg, gst, licence_number;
        public void openaccount()
        {
            read r = new read();//calling read class with object but same 
            banking b=r.reading();
            Console.WriteLine("Enter c_reg,gst,license in str");
            c_reg = Console.ReadLine();
            gst = Console.ReadLine().ToString();
            licence_number = Console.ReadLine().ToString();
            Console.WriteLine("Acoount created with name{0} and registration number{1}", b.name, c_reg);
        }
        public void deposite()
        {

        }
        public void withdraw()
        {

        }
        public void closeac()
        {

        }
    }
    class NRIacc : bank
    {
        string  c_status, p_details;
        public void openaccount()
        {
            read r = new read();
            banking b=r.reading();
            c_status = Console.ReadLine();
            p_details = Console.ReadLine();
            Console.WriteLine("Account created with user name{0}", b.name);
        }
        public void deposite()
        {

        }
        public void withdraw()
        {

        }
        public void closeac()
        {

        }
    }
    class interface_pointer
    {
        static void Main(string[] args)
        {
            int k = 0;
            do
            {
                Console.WriteLine("1-saving");
                Console.WriteLine("2-corpacc");
                Console.WriteLine("3-nri accc");
                int ver = int.Parse(Console.ReadLine());
                bank obj=null;//pointer to store the address of interface
                if (ver == 1)
                {
                    obj = new savingacc();
                    obj.openaccount();
                }
                else if (ver == 2)
                {
                    obj = new corpacc();
                    obj.openaccount();
                }
                else if (ver == 3)
                {
                    obj = new NRIacc();
                    obj.openaccount();
                }
                Console.WriteLine("1-contebue or 0-exit");
                k = int.Parse(Console.ReadLine());
            } while (k == 1);
        }
    }
}

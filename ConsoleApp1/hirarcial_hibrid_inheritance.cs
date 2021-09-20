using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class h_employee
    {
        int empno;
        string empname,address,email,phone;
        public void base_read()
        {
            Console.WriteLine("reading empno,empname,address,phone,email");
        }
        public void base_print()
        {
            Console.WriteLine("Printing all");
        }

    }
    class reg_emp : h_employee
    {
        int salary, pf, ta, tax, netsal;
        public void reg_read()
        {
            base.base_read();
            Console.WriteLine("reading salary, pf, ta, tax, netsal");
        }
        public void reg_print()
        {
            base.base_print();
            Console.WriteLine("Printing all");
        }
        public void monthly_pay()
        {
            Console.WriteLine("calculating monthly pay formula calculated netsal");
        }
    }
    //hirarcial
    class cont_emp : h_employee
    {
        int c_amnt,c_dura,gst,sa,mothlypay;
        public void cont_read()
        {
            base.base_read();
            Console.WriteLine("reading c_amnt,c_dura,gst,sa,mothlypay");
        }
        public void cont_print()
        {
            base.base_print();
            Console.WriteLine("Printing all");
        }
        public void cont_monthly_pay()
        {
            Console.WriteLine("calculating monthly pay formula calculated monthly pay");
        }
    }
    class frel_emp:h_employee
    {
        int h_pay,tds,a_all,weeklypay;
        public void free_read()
        {
            base.base_read();
            Console.WriteLine("reading h_pay,tds,a_all,weeklypay");
        }
        public void free_print()
        {
            base.base_print();
            Console.WriteLine("Printing all");
        }
        public void free_weekly_pay()
        {
            Console.WriteLine("calculating monthly pay formula calculated weekly pay");
        }
    }
    class hirarcial_hibrid_inheritance
    {
        static void Main(string[] args)
        {
            int key1 = 0;
            do
            {
                Console.WriteLine("Enter emplooye info");
                Console.WriteLine("1-regular employee");
                Console.WriteLine("2-contract employee");
                Console.WriteLine("3-Freelancer emplyee");
                Console.WriteLine("enter your option");
                int key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        reg_emp rg = new reg_emp();
                        rg.reg_print();
                        rg.monthly_pay();
                        rg.reg_print();
                        break;
                    case 2:
                        cont_emp co = new cont_emp();
                        co.cont_read();
                        co.cont_monthly_pay();
                        co.cont_print();
                        break;
                    case 3:
                        frel_emp fr = new frel_emp();
                        fr.free_read();
                        fr.free_weekly_pay();
                        fr.free_print();
                        break;
                    default:
                        break;

                }
                Console.WriteLine("press 1 to continue 0 to exit...");
                key1 = int.Parse(Console.ReadLine());
            } while (key1 == 1);
        }
    }
}

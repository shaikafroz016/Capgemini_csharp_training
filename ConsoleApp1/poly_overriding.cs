using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class over_ride1
    {
        public employe ob = new employe();
        public void read()
        {
            
            Console.WriteLine("Enter details of  employee");
            Console.WriteLine("Enter employe number");
            ob.emp_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employe name");
            ob.emp_name = Console.ReadLine();
            Console.WriteLine("Enter employe job");
            ob.em_job = Console.ReadLine();
            Console.WriteLine("Enter employe dept no");
            ob.dept_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employe salary");
            ob.salary = int.Parse(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine(ob.emp_name, ob.emp_no, ob.dept_no, ob.em_job, ob.salary);
        }
        public virtual void netsal()//methode to get must override ->virtual
        {
            Console.WriteLine(ob.salary-(12/ob.salary *100));//but what if formula is change then wehave to over ride it
        }
    }
    class over_ride2:over_ride1
    {
        public override void netsal()//methode has overrideen
        {
            Console.WriteLine("derived1....some formula changed, and not changed {0}",ob.salary/12);//now orignal formula changed. but what if again formula is changed? AGAIN OVER RIDE
        }
    }
    class over_ride3 : over_ride2
    {
        public override void netsal()//methode to get overrideen
        {
            Console.WriteLine("derived2....some formula is changed changed {0}",ob.salary/3);//but what if formula is change then wehave to over ride it
        }
        /*public void test()
        {
            Console.WriteLine("test");unable to access this method as the method ias controlled by base class
        }*/
    }
    class poly_overriding
    {
        static void Main(string[] args)
        {
            int k = 0;
            do
            {
                Console.WriteLine("1-version1");
                Console.WriteLine("2-version2");
                Console.WriteLine("3-version3");
                int ver = int.Parse(Console.ReadLine());
                over_ride1 obj;
                if (ver == 1)
                {
                    obj = new over_ride1();
                    obj.read();
                    obj.print();
                    obj.netsal();
                }
                else if (ver == 2)
                {
                    obj = new over_ride2();
                    obj.read();
                    obj.print();
                    obj.netsal();
                }
                else if (ver == 3)
                {
                    obj = new over_ride3();
                    obj.read();
                    obj.print();
                    obj.netsal();
                }
                Console.WriteLine("1-contebue or 0-exit");
                k = int.Parse(Console.ReadLine());
            } while (k == 1);
        }
    }
}

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleApp1
{   class salexceptio : Exception//creating mannual exception
    {
        public salexceptio():base("Salary must be in 10k to 2L")
        {
        }
    }
    class mannualexceptioclass
    {
        static void Main(string[] args)
        {   
            int empnum, deptno, salary;
            string name;
            Console.WriteLine("enter dept no,empnu,salary,name");
            try
            {
                empnum = int.Parse(Console.ReadLine());
                deptno = int.Parse(Console.ReadLine());
                salary = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                if (salary < 10000)
                {
                    throw new salexceptio();//calling mannual exception that is creatd
                }
                Console.WriteLine("salary is{0}", salary);
            }
            catch(salexceptio sl)//exception name
            {   
                Console.WriteLine("error in"+sl.Message.ToString());
            }
            finally
            {
                Console.WriteLine("this block will work even exception occur or not");
            }
        }
    }
}

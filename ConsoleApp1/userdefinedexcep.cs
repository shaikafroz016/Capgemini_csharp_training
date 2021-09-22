using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class userdefinedexcep
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
                    throw new Exception();
                }
                Console.WriteLine("salary is{0}", salary);
            }
            catch
            {
                Console.WriteLine("Salary mist be in 10k to 2L");
            }
            finally
            {
                Console.WriteLine("this block will work even exception occur or not");
            }

        }
    }
}

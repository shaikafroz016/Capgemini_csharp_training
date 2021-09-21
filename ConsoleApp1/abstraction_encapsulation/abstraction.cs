
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class abstraction
    {
        static void Main(string[] args)
        {
            employe ob = new employe();
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
            encap_dataconnect con = new encap_dataconnect();
            bool b=con.saveData(ob);
            if (b == true)
            {
                Console.WriteLine("Registered successfull..");
            }
            else
            {
                Console.WriteLine("enter the details correctly");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   
    
        class method_orl
        {
            employe obj = new employe();
            public method_orl(employe obj)
            {
                this.obj = obj;
            }

            public employe search(int empno)
            {
                employe obj1 = new employe();
                if (obj.emp_no == empno)
                {
                    obj1 = obj;
                }
                return obj1;
            }

            public employe search(string empname)
            {
                employe obj1 = new employe();
                if (obj.emp_name == empname)
                {
                    obj1 = obj;
                }
                return obj1;
            }

            public employe search(string empname, int deptno)
            {
                employe obj1 = new employe();
                if (obj.emp_name == empname && obj.dept_no == deptno)
                {
                    obj1 = obj;
                }
                return obj1;
            }
        }


        class polymorphism
        {
            static void Main(string[] args)
            {
                employe obj = new employe();

                Console.WriteLine("empno...");
                obj.emp_no = int.Parse(Console.ReadLine());

                Console.WriteLine("empname ...");
                obj.emp_name = Console.ReadLine();

                Console.WriteLine("job ...");
                obj.em_job = Console.ReadLine();

                Console.WriteLine("deptno...");
                obj.dept_no = int.Parse(Console.ReadLine());

                Console.WriteLine("salary...");
                obj.salary = int.Parse(Console.ReadLine());
                employe obj2;
                method_orl obj1 = new method_orl(obj);
                obj2 = obj1.search(1001);
                Console.WriteLine(obj2.ToString());

                obj2 = obj1.search("sam");
                Console.WriteLine(obj2.ToString());

                obj2 = obj1.search("sam", 20);
                Console.WriteLine(obj2.ToString());
            }
        }
    
}

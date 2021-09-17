using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class employe
    {
        public int emp_no { get; set; }
        public string emp_name { get; set; }
        public string em_job { get; set; }
        public int dept_no { get; set; }
        public int salary { get; set; }
    }
    class b_claas
    {
        List<employe> li = new List<employe>();
        public b_claas(List<employe> li)
        {
            this.li = li;
        }
        public List<employe> getdeptno(int dptno)
        {
            List<employe> empnames = new List<employe>();
            foreach(employe x in li)
            {
                if (x.dept_no == dptno)
                {
                    empnames.Add(new employe { emp_no = x.emp_no, emp_name = x.emp_name, em_job = x.em_job, dept_no = x.dept_no, salary = x.salary });
                }
            }
            return empnames;
        }
        public int sumsal(int deptno)
        {
            int sum = 0;
            foreach(employe x in li)
            {
                if (x.dept_no == deptno)
                {
                    sum += x.salary;
                }
            }
            return sum;
        }
        public int getBYdepNO(int empno)
        {
            int t=-1;
            for(int i = 0; i < li.Count; i++)
            {
                if (empno == li[i].emp_no)
                {
                    t=i;
                }
            }
            return t;
        }
        public void getbyjob(string job)
        {
            foreach(employe x in li)
            {
                if(x.em_job == job)
                {
                    int s = x.salary * 10 / 100;
                   x.salary += s;
                }
            }
        }
    }
    class asseignment_on_list
    {
        static void Main(string[] args)
        {
            List<employe> li = new List<employe>();
            int empno, dptno, sal, ch;
            string empnme, empjb;
            do
            {
                
                Console.WriteLine("Enter details of  employee");
                Console.WriteLine("Enter employe number");
                empno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employe name");
                empnme = Console.ReadLine();
                Console.WriteLine("Enter employe job");
                empjb = Console.ReadLine();
                Console.WriteLine("Enter employe dept no");
                dptno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employe salary");
                sal = int.Parse(Console.ReadLine()); 
                li.Add(new employe { emp_no=empno,emp_name=empnme,em_job=empjb,dept_no=dptno,salary=sal });
                Console.WriteLine("Contue or exit 0 or 1");
                ch = int.Parse(Console.ReadLine());
            } while (ch == 1);
            b_claas ob = new b_claas(li);
            Console.WriteLine("enter your option");
            Console.WriteLine("1-get employe name based on dept number");
            Console.WriteLine("2-Get sum of all emp salary based on department number");
            Console.WriteLine("3-getBYdepNO");
            Console.WriteLine("4-getbyjob");
            int key = int.Parse(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.WriteLine("Enter department number");
                    List<employe> nms = new List<employe>();
                    int t = int.Parse(Console.ReadLine());
                    nms= ob.getdeptno(t);
                    Console.WriteLine("The employee with matching detais are");
                    for(int i = 0; i < nms.Count; i++)
                    {
                        Console.Write("emp name={0}\t", nms[i].emp_name);
                        Console.Write("emp number={0}\t", nms[i].emp_no);
                        Console.Write("emp job={0}\t", nms[i].em_job);
                        Console.Write("emp salary={0}\t", nms[i].salary);
                        Console.Write("emp dept number={0}\t", nms[i].dept_no);
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Enter department number");
                    int te = int.Parse(Console.ReadLine());
                    int summ=ob.sumsal(te);
                    Console.WriteLine("The total salary is of dept number {0} is {1}", te, summ);
                    break;
                case 3:
                    Console.WriteLine("Enter department number");
                    int tem = int.Parse(Console.ReadLine());
                    int ind=ob.getBYdepNO(tem);
                    Console.WriteLine(li[ind]);
                    break;
                case 4:
                    Console.WriteLine("Enter department number");
                    string temp = Console.ReadLine();
                    ob.getbyjob(temp);
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
            }

        }
    }
}

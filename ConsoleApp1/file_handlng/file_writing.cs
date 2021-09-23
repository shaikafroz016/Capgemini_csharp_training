using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//connectiong system to retive or save files

namespace ConsoleApp1.file_handlng
{
    class file_writing
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("E://CG//emp.txt");//it used write into a file, if not exist it will create
            List<employe> emplst = new List<employe>();
            emplst.Add( new employe
            {
                emp_no = 1001,
                emp_name = "sam",
                em_job = "manager",
                dept_no = 10,
                salary = 8000
            });
            emplst.Add(new employe
            {
                emp_no = 1002,
                emp_name = "rahul",
                em_job = "manager",
                dept_no = 20,
                salary = 9000
            });
            emplst.Add(new employe
            {
                emp_no = 1003,
                emp_name = "sanjay",
                em_job = "admin",
                dept_no = 30,
                salary = 6000
            });
            sw.WriteLine("employe list");//writing heading in emp.txt file
            foreach(employe x in emplst)
            {
                sw.WriteLine(x.emp_name+" "+" "+x.emp_no+" "+x.dept_no);//writing lines in emp.txt file
            }
            sw.Flush();//we must free memory
            sw.Close();//we must close the connection in order to complete task 
            StreamReader sr = new StreamReader("e://CG//emp.txt");//reading file
            string st=sr.ReadToEnd();//reading till end
            Console.WriteLine(st);
            
        }
    }
}

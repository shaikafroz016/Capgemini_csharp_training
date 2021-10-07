using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Webappwithdbs.Models;
namespace Webappwithdbs.Controllers
{
    public class EmployeController : Controller
    {
        //cnonection string sqlmgmt studio->right click on server->properties->connection name
        //open vscode->tools->connect to db->enter database name copied from sqlmgmt->select db->advanced->copy conn string->OK
        SqlConnection con = new SqlConnection(@"Data Source=adminvm\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True");
        List<Employe> li = new List<Employe>();
        List<Department> ld = new List<Department>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult test()
        {
            return View();
        }
        public IActionResult getrec()
        {
            
            con.Open();                                                     //opening sql coonection and must be closed
            SqlDataAdapter ad = new SqlDataAdapter("use emp select * from emp  ",con);//gathering all values inside table. But can't understand when printed
            DataSet ds = new DataSet();                                     //using dataset and printing to see
            ad.Fill(ds, "emp1");                                            //fill is a object which used to fill sql data into dataset table
            for (int i = 0; i < ds.Tables["emp1"].Rows.Count; i++)
            {
                Employe obj = new Employe();
                obj.empno = int.Parse(ds.Tables["emp1"].Rows[i].ItemArray[0].ToString());
                obj.empname = ds.Tables["emp1"].Rows[i].ItemArray[1].ToString();
                obj.job = ds.Tables["emp1"].Rows[i].ItemArray[2].ToString();
                obj.deptno = int.Parse(ds.Tables["emp1"].Rows[i].ItemArray[3].ToString());
                obj.salary = int.Parse(ds.Tables["emp1"].Rows[i].ItemArray[4].ToString());
                li.Add(obj);
            }
            //return View(li);
            var sumsal = li.Sum(x => x.salary);//lamda functions here x acts as a itreator with temp x
            var avgsalary = li.Average(x => x.salary);
            ViewBag.sumsal = sumsal;
            ViewBag.avgsal = avgsalary;
            var lin = from l in li where l.empno > 1007 select new { l.empno,l.empname,l.deptno,l.job,l.salary};//using linq syntax we can directly manuplate with values
            List<Employe> lis = new List<Employe>();
            foreach(var x in lin)
            {
                Employe o = new Employe();
                o.empno = x.empno;
                o.deptno = x.deptno;
                o.empname = x.empname;
                o.job = x.job;
                o.salary = x.salary;
                lis.Add(o);
            }
            con.Close();                                                    //closing connection
            return View(lis);
        }
        public IActionResult getdeptrec()
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("use emp select * from dept", con);
            DataSet ds = new DataSet();                                     //using dataset and printing to see
            ad.Fill(ds, "dept");
            Department d;
            for (int i = 0; i < ds.Tables["dept"].Rows.Count; i++)
            {
                d = new Department();
                d.deptno = int.Parse(ds.Tables["dept"].Rows[i].ItemArray[0].ToString());
                d.deptname = ds.Tables["dept"].Rows[i].ItemArray[1].ToString();
                d.loc_name = ds.Tables["dept"].Rows[i].ItemArray[2].ToString();
                ld.Add(d);
            }
            //var res = from l in ld where l.deptno==10 select l;
            //foreach(var x in res)
            //{
            //    d = new Department();
            //    d.deptno = x.deptno;
            //    d.deptname = x.deptname;
            //    d.loc_name = x.loc_name;
            //    ld.Add(d);
            //}
            con.Close();
            return View(ld);
        }
            public IActionResult joinn()
            {
            List<EmpDpt> led = new List<EmpDpt>();
            var result6 = from empobj in li
                          join dptobj in ld on empobj.deptno equals dptobj.deptno+10
                          orderby empobj.empno
                          select new
                          {
                              empobj.empno,
                              empobj.empname,
                              empobj.job,
                              empobj.deptno,
                              empobj.salary,
                              dptobj.deptname,
                              dptobj.loc_name
                              };
            foreach(var x in result6)
            {
                EmpDpt ed = new EmpDpt();
                ed.empno = x.empno;
                ed.empname = x.empname;
                ed.job = x.job;
                ed.salary = x.salary;
                ed.loc_name = x.loc_name;
                ed.deptno = x.deptno;
                ed.deptname = x.deptname;
                led.Add(ed);

            }
                return View(led);
            }
        
    }
}

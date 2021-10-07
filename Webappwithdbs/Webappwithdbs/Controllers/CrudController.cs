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
    public class CrudController : Controller
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F5M5DBC;Initial Catalog=Employe;Integrated Security=True");
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult register()
        {
            return View();
        }
        public IActionResult registeremp(int empno,string empname,string job,int deptno,int salary)
        {
            con.Open();
            Employe obj = new Employe();
            obj.empno = empno;
            obj.empname = empname;
            obj.job = job;
            obj.deptno = deptno;
            obj.salary = salary;
            SqlCommand cmd = new SqlCommand(" insert into emp values(" + obj.empno + ",'" + obj.empname + "','" + obj.job + "'," + obj.deptno + "," + obj.salary + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ViewBag.status = "success...";
            return View("register");
        }
        public IActionResult update()
        {
            return View();
        }
        public IActionResult updateemp(int empno)
        {
            con.Open();
                Employe obj = new Employe();
                SqlDataAdapter ad = new SqlDataAdapter(" select * from emp where empno=" + empno + "", con);
                DataSet ds = new DataSet();
                ad.Fill(ds, "emp2");

                ViewBag.empno = ds.Tables["emp2"].Rows[0].ItemArray[0].ToString();
                ViewBag.empname = ds.Tables["emp2"].Rows[0].ItemArray[1].ToString();
                ViewBag.job = ds.Tables["emp2"].Rows[0].ItemArray[2].ToString();
                ViewBag.deptno = ds.Tables["emp2"].Rows[0].ItemArray[3].ToString();
                ViewBag.salary = ds.Tables["emp2"].Rows[0].ItemArray[4].ToString();
            con.Close();
            return View();
        }
        public ActionResult Update2(string text1, string text2, string text3, string text4, string text5)
        {
            con.Open();
            Employe obj = new Employe();
            obj.empno = int.Parse(text1);
            obj.empname = text2;
            obj.job = text3;
            obj.deptno = int.Parse(text4);
            obj.salary = int.Parse(text5);

            SqlCommand cmd = new SqlCommand("update emp set empno=" + obj.empno + ",empname='" + obj.empname + "',job='" + obj.job + "',deptno=" + obj.deptno + ",salary=" + obj.salary + " where empno=" + obj.empno + "", con);
            cmd.ExecuteNonQuery();


            con.Close();

            return RedirectToAction("getrec", "Employe");
        }
        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Delete1(string text1)
        {
            int empno = int.Parse(text1);
            con.Open();
            SqlCommand cmd = new SqlCommand("use Employe delete from emp where empno=" + empno + "", con);
            cmd.ExecuteNonQuery();


            con.Close();

            return Content("Deleted....");
        }
    }
}

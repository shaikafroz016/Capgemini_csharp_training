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
        //connection string sqlmgmt studio->right click on server->properties->connection name
        //open vscode->tools->connect to db->enter database name copied from sqlmgmt->select db->advanced->copy conn string->OK
        SqlConnection con = new SqlConnection(@"Data Source=adminvm\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True");
        List<Employe> li = new List<Employe>();
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
            SqlDataAdapter ad = new SqlDataAdapter("use emp select * from emp",con);//gathering all values inside table. But can't understand when printed
            DataSet ds = new DataSet();                                     //using dataset and printing to see
            ad.Fill(ds, "emp1");                                            //fill is a object which used to fill sql data into dataset table
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Employe obj = new Employe();
                obj.empno = int.Parse(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                obj.empname = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                obj.job = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                obj.deptno = int.Parse(ds.Tables[0].Rows[i].ItemArray[3].ToString());
                obj.salary = int.Parse(ds.Tables[0].Rows[i].ItemArray[4].ToString());
                li.Add(obj);
            }
            con.Close();                                                    //closing connection
            return View(li);
        }
    }
}

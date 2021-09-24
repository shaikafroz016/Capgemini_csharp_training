using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Patient
    {
        public int patient_id { get; set; }
        public string patiend_name { get; set; }
        public string doctor_name { get; set; }
        public string health_issue { get; set; }
        public int ward_number { get; set; }
    }
    class p_mang
    {
        List<Patient> li = new List<Patient>();
        public p_mang(List<Patient> li)
        {
            this.li = li;
            
        }


        public List<Patient> addl(Patient obj1)
        {
            
            li.Add(obj1);
            return li;
        }

        public Patient search(int patienceid)
        {
            Patient k = new Patient();
            foreach (Patient x in li)
            {
                if (x.patient_id == patienceid)
                {
                    k = x;
                }
                else
                {
                    k = null;
                }
            }
            return k;
        }
        
        public Patient update(int patienceid)
        {
            Patient p = new Patient();
            foreach (Patient x in li)
            {
                if (x.patient_id == patienceid)
                {
                    Console.WriteLine("update record");
                    Console.WriteLine("Enter patient_id,patient_name,doctor_name,helth_issue,ward number");
                    x.patient_id = int.Parse(Console.ReadLine());
                    x.patiend_name = Console.ReadLine();
                    x.doctor_name = Console.ReadLine();
                    x.health_issue = Console.ReadLine();
                    x.ward_number = int.Parse(Console.ReadLine());
                    p = x;
                }

            }
            return p;

        }

        public List<Patient> delete(int patienceid)
        {
            bool flag = false;
            for(int i=0;i<li.Count;i++)
            {
                if (li[i].patient_id == patienceid)
                {
                    li.RemoveAt(i);
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Enter correct id");
            }
            return li;
        }

    }
    class patent_test
    {
        static void Main(string[] args)
        {
            try { 
            List<Patient> li = new List<Patient>();
            int k = 0;
            do
            {
                Patient p = new Patient();
                Console.WriteLine("Enter patient_id,patient_name,doctor_name,helth_issue,ward number");
                p.patient_id = int.Parse(Console.ReadLine());
                p.patiend_name = Console.ReadLine();
                p.doctor_name = Console.ReadLine();
                p.health_issue = Console.ReadLine();
                p.ward_number = int.Parse(Console.ReadLine());
                li.Add(p);
                Console.WriteLine("Enter 1-continue or 0-exit");
                k = int.Parse(Console.ReadLine());
            } while (k == 1);
            int key = 0;
            p_mang pm = new p_mang(li);
            Console.WriteLine("1-add patent list");
            Console.WriteLine("2-search patent");
            Console.WriteLine("3-update patent details");
            Console.WriteLine("4-delete patent details");
            Console.WriteLine("Enter details");
            key = int.Parse(Console.ReadLine());
           
                switch (key)
                {
                    case 1:
                        Patient p = new Patient();
                        Console.WriteLine("Enter patient_id,patient_name,doctor_name,helth_issue,ward number");
                        p.patient_id = int.Parse(Console.ReadLine());
                        p.patiend_name = Console.ReadLine();
                        p.doctor_name = Console.ReadLine();
                        p.health_issue = Console.ReadLine();
                        p.ward_number = int.Parse(Console.ReadLine());
                        List<Patient> pt = pm.addl(p);
                        Console.WriteLine("Patent added seccuefully");
                        foreach (Patient x in pt)
                        {
                            Console.WriteLine("patient_id={0} patient_name={1} doctor_name={2} helth_iisue={3} ward_number={4}", x.patient_id, x.patiend_name, x.doctor_name, x.health_issue, x.ward_number);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter patent id to search");
                        int ser = int.Parse(Console.ReadLine());
                        p = pm.search(ser);
                        if (p == null)
                        {
                            Console.WriteLine("record not found");
                        }
                        else
                        {
                            Console.WriteLine("patent name={0} and id={1} ", p.patiend_name, p.patient_id);
                        }
                        break;
                    case 3:
                        int upkey = int.Parse(Console.ReadLine());
                        p = pm.update(upkey);
                        Console.WriteLine("Updated details are");
                        Console.WriteLine("patient_id={0} patient_name={1} doctor_name={2} helth_iisue={3} ward_number={4}", p.patient_id, p.patiend_name, p.doctor_name, p.health_issue, p.ward_number);
                        break;
                    case 4:
                        Console.WriteLine("enter patent id to delete");
                        int delkey = int.Parse(Console.ReadLine());
                        List<Patient> del = pm.delete(delkey);
                        Console.WriteLine("After deleting patent id={0} new records are...", delkey);
                        foreach (Patient x in del)
                        {
                            Console.WriteLine("patient_id={0} patient_name={1} doctor_name={2} helth_iisue={3} ward_number={4}", x.patient_id, x.patiend_name, x.doctor_name, x.health_issue, x.ward_number);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("EXception occured" + ex.Message.ToString());
            }
            }
    }
}

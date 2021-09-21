using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class encap_dataconnect
    {
        bool flag = false;
        public bool saveData(employe obj)
        {
            if (tech_valid(obj) == true)
            {
                flag = true;
            }
            return flag;
        }

        private bool tech_valid(employe obj)
        {
            if (obj.salary.ToString().Length >= 5)
            {
                if (func_valid(obj) == true)
                {
                    flag = true;
                }
            }
            return flag;
        }
        private bool func_valid(employe obj)
        {
            bool flag = false;
            if (obj.dept_no <= 30)
            {
                flag = true;
            }
            return flag;

        }
    }
}

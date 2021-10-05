using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class cl_lass1
    {
        public int x = 10;
        public int print()
        {
            return x;
        }
    }
    public class cl_class2:cl_lass1
    {
        public int y = 20;
        public int print1()
        {
            return x + y;
        }
    }
}

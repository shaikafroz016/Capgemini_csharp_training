using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   partial class p_class//partial class is physically seprated but logically all are one
    {
        public void m1()
        {

        }
        public void m2()
        {

        }
    }
    partial class p_class// the class name is same here which indicate that two classes are same with keyword partial
    {                    //partial class is used to access the completed method, which is not completed then it store to
                         //another partial class. so when it complrted it is accessable parlelly -->partial class
        public void m3()
        {

        }
        public void m4()
        {

        }
    }
    class partial_class
    {
        static void Main(string[] args)
        {
            p_class pc = new p_class();
            pc.m1();
            pc.m4();//as both classes are same we can access two classes with same object
        }
    }
}

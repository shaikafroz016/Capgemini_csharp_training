using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class cls1
    { int x, y, z;
        public cls1()
        {
            Console.WriteLine("Default constructor");
        }
        public cls1(int y,int z)
        {
            x = 100;
            this.y = y;
            this.z = z;
            Console.WriteLine("inside two parameter constructor {0} {1} {2}",x,y,z );
        }
        //with all parameter
        public cls1(int x,int y,int z)
        {
            x = x;//locally storing can't be accesseble outside the constructor(copy cunstructor)
            this.y = y;
            this.z = z;
            Console.WriteLine("inside three parameter constructor {0} {1} {2}", x, y, z);

        }
        // copy cunstructor
        public cls1(cls1 obj2)
        {
            x = obj2.x;//x will be 0 as it is stored in locally in previous constructor
            this.y = obj2.y;
            this.z = obj2.z;
            Console.WriteLine("inside copy cunstructor parameter constructor {0} {1} {2}", x, y, z);
        }
    }
    class constructor
    {
        static void Main(string[] args)
        {
            cls1 ob = new cls1();
            cls1 ob1 = new cls1(10, 20);
            cls1 ob2 = new cls1(10, 20, 30);
            cls1 ob3 = new cls1(ob2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
    //multilevel inheritance
{   class one
    {
        int x, y, z;
        public one(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void methode1()
        {
            Console.WriteLine("inside methode 1 x={0} y={1} z={2}", x, y, z);
        }
    }
    class two:one
    {
        int x, y;
        String z;
        public two(int x, int y, string z):base(x,y,x)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void methode2()
        {
            Console.WriteLine("inside methode 2 x={0} y={1} z={2}", x, y, z);
        }
    }
    class three:two
    {
        int x;
        string y, z;
        public three(int x, string y, string z):base(x,x,y)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void methode3()
        {
            Console.WriteLine("inside methode 3 x={0} y={1} z={2}", x, y, z);
        }
    }
    class constructorchaning
    {
        static void Main(string[] args)
        {
            three ob=new three(5,"Shaik","Afroz");
            ob.methode1();
            ob.methode2();
            ob.methode3();

        }
    }
}

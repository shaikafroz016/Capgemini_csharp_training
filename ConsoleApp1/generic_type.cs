using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class gen<T>//generic data type we will pass t as data type here. we can pass multiple data-types
    {
        T a, b;
        public gen(T a,T b)
        {
            this.a = a;
            this.b = b;
        }
        public void print()
        {
            Console.WriteLine("a={0},b={1}", a, b);
        }
    }
    class mul_gen<D,D1,D2>
    {
        D a, b;
        D1 c;
        D2 d;
        public mul_gen(D a,D b,D1 c,D2 d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public void print()
        {
            Console.WriteLine("a={0},b={1},c={2},d={3}", a, b,c,d);
        }
    }

    class generic_type
    {
        static void Main(string[] args)
        {
            gen<int> ob = new gen<int>(10, 20);//here we are passing int as a data-type for gen class
            ob.print();
            mul_gen<int, string, int> obj = new mul_gen<int, string, int>(10, 20, "sks", 100);//here we are passing threee data-types
            obj.print();
        }
    }
}

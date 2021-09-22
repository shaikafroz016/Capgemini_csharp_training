using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{   class D
    {

    }
    sealed class A:D//lass a can be inherited but it will not going to inherit to it's child class
    {

    }
    //class B : A can't be accessable as sealed class can't be inherited
    //{

    //}
    class sealed_class
    {
    }
}

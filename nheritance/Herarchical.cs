using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Herarchical
    {
        public void dis1()
        {
            Console.WriteLine("this is my parent class");
        }
    }
    class Child1 : Herarchical
    {
        public void dis2()
        {
            Console.WriteLine("this is my child class 1");
        }
    }

        class Child2 :Herarchical {
            public void dis3()
        {
            Console.WriteLine("this is my child class 2");
        }
    }
        class Child3 :Herarchical{
            public void dis4()
        {
            Console.WriteLine("this is my child class 3");
        }
    }
    }

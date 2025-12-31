using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Polymorphism
{
    internal class MehtodOverloading
    {
        public void add(int a,int b)
        {
            Console.WriteLine("the sum is", a+b);
        }

        public void add(string a,string b)
        {
            Console.WriteLine( "your Concatination String",a+b);
        }

        public void add(int a,int b,int c)
        {
            Console.WriteLine("Sum of 3 integers is ", a + b + c);
        }
    }
}

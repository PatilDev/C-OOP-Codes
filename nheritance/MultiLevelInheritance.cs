using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
   class MultiLevelInheritance
    {
        public int p = 10;
        public void disP()
        {
            Console.WriteLine("Its i  my mutilevel parent 1 class");
        }
    }
    class A : MultiLevelInheritance
    {
        public int a = 20;
        public void disA()
        {
            Console.WriteLine("its is class 2");
        }
    }
    class MultiLevelChild : A
    {
        public int b = 30;

        public void disB()
        {
            Console.WriteLine("its is child class");
            Console.WriteLine("P class variable\t" + base.p + "\n Class A vaiable \t" + base.a+"\n self class variable\t"+this.b);

        }
    }
}

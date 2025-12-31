using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Inheritance
{
    class SingleInheritance
    {

         public int a = 10;
    public void disA()
        {
            Console.WriteLine($"its my paent class parent {a}");
        }
    }

    class Child : SingleInheritance
    {
         private int b = 20;
        public void disB()
        {
            base.disA(); /*the base.methidname is used to handle the parent class method
                          its firstly check is method prensent in parent class*/
          
            Console.WriteLine("Its my child class");

            Console.WriteLine("---------------------------");
            Console.WriteLine("varible use from paret class using base.variable name");
            Console.WriteLine(base.a);
            Console.WriteLine("Variable from self class in to method using this.veriable or direct varible name name");
            Console.WriteLine(this.b+"{0}",b);
        }

    }
}

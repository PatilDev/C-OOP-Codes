using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    internal class ForLoop
    {
        public void loop()
        {
            for (int i = 0; i <= 10; i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
      

    }
}

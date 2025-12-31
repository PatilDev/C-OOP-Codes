using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    internal class Switch
    {
        public void SwitchCase()
        {
            Console.WriteLine(" Enter 0 for * program");
            Console.WriteLine("Enter 1 for check numis prime or not");
            Console.WriteLine("Enter 2 to get hello msg");

            Console.WriteLine("ENTER YOUR CHOISE :-  ");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 0:
                    ForLoop forloop = new ForLoop();
                    forloop.loop();
                    break;
                case 1:
                    Prime prime = new Prime();
                    prime.isPrime();
                    break;
                case 2:
                    Console.WriteLine("hello");
                    break;
                default:
                    Console.WriteLine("Enter Valid number");
                    break;

            }

            SwitchCase();

        }
    }
}

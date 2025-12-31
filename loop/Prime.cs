using System;

namespace loop
{
    internal class Prime
    {
        public void isPrime()
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1)
            {
                Console.WriteLine("Not a prime number");
                return;
            }

            int i = 2;
            bool isPrime = true;

            while (i <= num / 2)
            {
                if (num % i == 0)   // Correct condition
                {
                    isPrime = false;
                    break;
                }
                i++;
            }

            if (isPrime)
                Console.WriteLine($"{num} is a Prime number");
            else
                Console.WriteLine($"{num} is NOT a Prime number");
        }
    }
}

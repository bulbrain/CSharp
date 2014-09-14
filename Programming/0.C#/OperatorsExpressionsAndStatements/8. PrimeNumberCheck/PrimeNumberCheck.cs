// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
using System;

class primeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer, lower than 100:");
        int n = int.Parse(Console.ReadLine());
        int p = 0 ;
        if ((n < 0) || (n > 100))
        {
            Console.WriteLine("Your number must be positive and lower than 100.");
        }
        else
        if ((n == 1) || (n == 0))
        {
            Console.WriteLine("The number {0} isn't prime", n);
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    p = p + 1;
                }
                else
                {
                    p = p + 0;
                }
            }
            if (p == 0)
            {
                Console.WriteLine("The number {0} is prime.", n);
            }
            else
            {
                Console.WriteLine("The number {0} isn't prime.", n);
            }
        }

    }
}

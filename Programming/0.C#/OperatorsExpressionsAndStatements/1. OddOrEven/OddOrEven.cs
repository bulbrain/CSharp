// Write an expression that checks if given integer is odd or even.
using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        bool Odd;

        if (n % 2 == 0)
        {
        Odd = false; 
        }
        else
        {
        Odd = true;
        }
        Console.WriteLine("Is {0} odd? {1}", n, Odd);
    }
}
using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter the first number.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number.");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("**********************");
        if (a < 0)
        {
            if (b < 0)
            {
                if (c < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            else
            {
                if (c < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
        else if (a > 0)
        {
            if (b < 0)
            {
                if (c < 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            else
            {
                if (c < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
        else if ((a == 0) || (b == 0) || (c == 0))
        {
            Console.WriteLine("0");
        }
    }
}
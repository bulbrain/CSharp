using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter the first variable:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second variable:");
        double b = double.Parse(Console.ReadLine());
        double c = 0;
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("***************");
        Console.WriteLine("{0} {1}", a, b);
    }
}
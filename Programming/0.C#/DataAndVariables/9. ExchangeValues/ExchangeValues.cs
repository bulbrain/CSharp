using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("{0}, {1}",a, b);
        int c;
        c = a;
        a = b;
        b = c;
        Console.WriteLine("{0}, {1}",a, b);
    }
}
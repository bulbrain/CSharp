using System;

class NullValues
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("A = {0}",a);
        Console.WriteLine("B = {0}",b);
        a = 123;
        b = 321;
        Console.WriteLine("A = {0}", a);
        Console.WriteLine("B = {0}", b);
    }
}
using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        string empty = " ";
        char symbol = (char)0XA9;
        Console.WriteLine(empty + empty + empty + symbol);
        Console.WriteLine(empty + empty + symbol + empty + symbol);
        Console.WriteLine(empty + symbol + empty + empty + empty + symbol);
        Console.WriteLine(symbol + empty + symbol + empty + symbol + empty + symbol);
    }
}
using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i=i+2)
        {
            Console.Write(" " + i);
            Console.Write(",");
            Console.Write(" " + -(i + 1));
            Console.Write(",");
        }
    }
}
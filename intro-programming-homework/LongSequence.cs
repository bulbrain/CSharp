using System;

class LongSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i=i+2)
        {
            Console.Write(" " + i);
            Console.Write(",");
            Console.Write(" " + -(i + 1));
            Console.Write(",");
        }
    }
}
// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 
using System;

class DivideFiveSeven
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        bool divide;

        if (n % 5 == 0 && n % 7 == 0)
        {
            divide = true;
        }
        else
        {
            divide = false;
        }
        Console.WriteLine("Can {0} be divided by 5 and 7 at the same time? {1}", n, divide);
    }
}
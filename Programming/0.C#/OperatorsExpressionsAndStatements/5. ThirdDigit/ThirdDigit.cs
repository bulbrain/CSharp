// Write an expression that checks for given integer if its third digit from right-to-left is 7. 
using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        int a = n / 100;
        int b = a % 10;
        bool seven;
        if (b == 7)
        {
            seven = true;
        }
        else
        {
            seven = false;
        }
        Console.WriteLine("The 3rd digit of the number {0} is seven? {1}", n, seven);
    }
}
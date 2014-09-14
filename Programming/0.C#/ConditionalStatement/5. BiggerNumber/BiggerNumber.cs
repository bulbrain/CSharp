using System;

class BiggerNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the first number.");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number.");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number.");
        double c = double.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("The bigger number is: " + a);
        }
        else
        if (b > a && b > c)
        {
            Console.WriteLine("The bigger number is: " + b);
        }
        else
        {
            Console.WriteLine("The bigger number is: " + c);
        }
    }
}
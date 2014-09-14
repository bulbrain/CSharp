// Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in
// 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal,
// left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2
// digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left alligned.
using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert integer A:");
        int a = int.Parse(Console.ReadLine());
        if (a < 0 || a > 500)
        {
            Console.WriteLine("Invalid integer, must be positive and lower than 500.");
        }
        else
        {
            Console.WriteLine("Insert float B:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Insert float C:");
            float c = float.Parse(Console.ReadLine());
            string bin = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("|{0,-10:X}|{1,-10}|{2,10:0.00}|{3,-10:0.000}|",a,  bin, b, c);
        }
    }
}
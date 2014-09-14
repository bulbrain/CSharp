using System;

class ComparingFloats
{
    static void Main()
    {
        float a = 5.00000001f;
        float b = 5.00000003f;
        CompareNumbers((decimal)a, (decimal)b);

    }

    private static void CompareNumbers(decimal a, decimal b)
    {
        if (Math.Abs(a - b) < 0.000001m)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
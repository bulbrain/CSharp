using System;

class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());
        if (score < 1 || score > 9)
        {
            Console.WriteLine("Invalid score.");
        }
        else if (score < 4)
        {
           score = score * 10;
           Console.WriteLine("Result:" + score);
        }
        else if (score < 7)
        {
            score = score * 100;
            Console.WriteLine("Result:" + score);
        }
        else if (score < 10)
        {
            score = score * 1000;
            Console.WriteLine("Result:" + score);
        }
    }
}
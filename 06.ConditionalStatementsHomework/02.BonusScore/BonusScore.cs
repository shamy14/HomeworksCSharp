using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Score: ");
        int score = int.Parse(Console.ReadLine());
        if (score >= 1 && score <= 9)
        {
            if (score >= 1 && score <= 3)
            {
                score = score * 10;
                Console.WriteLine("Result: {0}", score);
            }
            else if (score >= 4 && score <= 6)
            {
                score = score * 100;
                Console.WriteLine("Result: {0}", score);
            }
            else if (score >= 7 && score <= 9)
            {
                score = score * 1000;
                Console.WriteLine("Result: {0}", score);
            }
        }
        else
        {
            Console.WriteLine("Invalid Score");
        }
    }
}

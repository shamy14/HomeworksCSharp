using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Въведете стойност за a: ");
        double a = double.Parse(Console.ReadLine());
        a = Math.Round(a, 2);
        Console.Write("Въведете сойност за b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("По-голямото е: " + Math.Max(a, b));

    }
}

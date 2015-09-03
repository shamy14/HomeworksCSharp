using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        //Without if statements :)
        Console.WriteLine("Enter value for a, b, c, d and e:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double maxAB = Math.Max(a, b);
        double maxCD = Math.Max(c, d);
        double max = Math.Max(Math.Max(maxAB,maxCD),e);
        Console.WriteLine("Biggest: {0}", max);
    }
}

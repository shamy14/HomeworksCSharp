using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter value for a,b and c:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a > 0 && b > 0 && c > 0 ||
            a < 0 && b < 0 && c > 0 ||
            a > 0 && b < 0 && c < 0 ||
            a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("Result: +");
        }
        else if (a < 0 && b > 0 && c > 0 ||
                 a > 0 && b < 0 && c > 0 ||
                 a > 0 && b > 0 && c < 0 ||
                 a < 0 && b < 0 && c < 0)
        {
            Console.WriteLine("Result: -");
        }
        else
        {
            Console.WriteLine("Result: 0");
        }
    }
}

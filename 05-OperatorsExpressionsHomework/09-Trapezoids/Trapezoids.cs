using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter a ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter h");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("(({0} + {1}) * {2}) /2 = {3}", a, b, h, ((a + b) * h) / 2);
    }
}

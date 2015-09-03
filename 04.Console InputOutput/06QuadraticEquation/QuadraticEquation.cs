using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = 0;
        double b = 0;
        double c = 0;
        double d = 0;

        Console.Write("Въведете сойност за a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Въведете сойност за b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Въведете сойност за c: ");
        c = double.Parse(Console.ReadLine());

        d = Math.Pow(b, 2) - (4 * a * c);

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (d > 0)
        {
            Console.WriteLine("x1= {0}", (-b - Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("x2= {0}", (-b + Math.Sqrt(d)) / (2 * a));
        }
        else
        {
            Console.WriteLine("x1=x2= {0}", (-b / (2 * a)));
        }
    }
}

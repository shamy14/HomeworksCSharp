using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Въведете радиус r: ");
        double r = double.Parse(Console.ReadLine());
        r = Math.Round(r, 2);
        double perimeter = 2 * Math.PI * r;
        perimeter = Math.Round(perimeter, 2);
        double area = Math.PI * Math.Pow(r, 2);
        area = Math.Round(area, 2);
        Console.WriteLine("Perimeter: {0}", perimeter);
        Console.WriteLine("Area: {0}", area);
    }
}

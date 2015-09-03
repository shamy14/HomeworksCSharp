using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter Width");
        double Width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Height");
        double Height = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimeter " + ((Width * 2) + (Height * 2)));
        Console.WriteLine("Area " + (Width * Height));
    }
}

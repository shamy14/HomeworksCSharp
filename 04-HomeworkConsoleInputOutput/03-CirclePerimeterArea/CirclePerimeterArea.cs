using System;

    class CirclePerimeterArea
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}",2*r*3.141592);
            Console.WriteLine("{0:0.00}",3.141592*r*r);
        }
    }


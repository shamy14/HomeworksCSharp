using System;
class ComparingFloats{
    static void Main(){
        double eps = 0.000001;
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        if (a - b < eps)
        {
            Console.WriteLine("a and b are equal.");
        }
        else{
            Console.WriteLine("They are not equal.");
        }
    }
}

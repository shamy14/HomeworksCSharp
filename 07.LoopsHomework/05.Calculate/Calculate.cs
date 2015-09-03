using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Enter two whole numbers n and x:");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        decimal factorial = 1;
        decimal defactorial = 0;
        decimal sum = 0;
        for (int i = 1; i <=n; i++)
        {
            factorial *= i;
            defactorial = factorial / (decimal)Math.Pow(x, i);
            sum += defactorial;
        }
        Console.WriteLine("{0:F5}",sum + 1,0M);
    }
}

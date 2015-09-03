using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        int colum = 1;
        if (n <= 1 || n >= 20)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < 2 * n; j++)
            {
                if (colum <= n)
                {
                    Console.Write("{0} ", j);
                    colum++;
                }
            }
            Console.WriteLine();
            colum = 1;
        }
    }
}

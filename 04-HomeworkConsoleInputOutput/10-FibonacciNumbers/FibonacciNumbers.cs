using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 1;
            if (n==1)
            {
                Console.WriteLine(0);
                
            }
            if (n>=2)
            {
                Console.Write("0, 1");
            }
            for (int i = 2; i < n; i++)
            {
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber += firstNumber;
                Console.Write(", "+thirdNumber);

            }
            Console.WriteLine();
        }
    }


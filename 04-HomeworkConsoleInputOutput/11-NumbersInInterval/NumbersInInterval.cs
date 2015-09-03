using System;

    class NumbersInInterval
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            while (startNumber<=endNumber)
            {
                if (startNumber%5==0)
                {
                    counter++;
                }
                startNumber++;
            }
            Console.WriteLine(counter);
        }
    }


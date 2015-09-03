using System;

    class WorkHours
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double work = d * 0.9 * 12 * p / 100;
            if (Math.Floor(work - h)>=0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine(Math.Floor(work - h));

        }
    }


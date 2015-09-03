using System;

    class NewHouse
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int roofNumber = (n + 1) / 2;
            for (int i = 1, j =1; i <= n; i+=2,j++)
            {
                Console.WriteLine(new string('-',roofNumber-j)+new string('*',i)+new string('-',roofNumber-j));
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("|"+ new string('*',n-2)+"|");
            }
        }
    }


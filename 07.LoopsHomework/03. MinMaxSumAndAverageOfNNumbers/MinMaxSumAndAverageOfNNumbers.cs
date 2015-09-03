using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter varlue for N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int min = arr[0];
        int max = arr[0];
        int sum = 0;
        for(int i=0;i<n;i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }
        for (int i = 1; i < n; i++)
        {   
            if (min>arr[i])
            {
                min = arr[i];
            }
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        Console.WriteLine("min = {0}",min);
        Console.WriteLine("max = {0}",max);
        Console.WriteLine("sum = {0}",sum);
        Console.WriteLine("average = {0}",(double)sum/2);
    }
}

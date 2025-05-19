using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long[] tags = new long[n];

        if (n >= 1)
        {
            tags[0] = 1;
        }

        if (n >= 2)
        {
            tags[1] = 1;
        }

        for (int i = 2; i < n; i++)
        {
            tags[i] = tags[i - 1] + tags[i - 2];
        }

        long totalTime = 0;
        for (int i = 0; i < n; i++)
        {
            totalTime += tags[i];
        }

        Console.WriteLine(totalTime);
    }
}


//ЗАДАЧА 1
using System;

class Program 
{
    static void Main() 
    {
        string[] input = Console.ReadLine().Split();
        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);

        Console.WriteLine(a + b);

    }
}


//ЗАДАЧА 2

using System;

class Program 
{
    static void Main() 
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
        
    }
}



//ЗАДАЧА 3

using System;

class Program 
{
    static void Main() 
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int count = 0;

        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine(count);
        
    }
}



// ЗАДАЧА 4

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


// ЗАДАЧА 5

using System;

class Program 
{
    static void Main() 
    {

        string[] input = Console.ReadLine().Split();
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine(0);
        }
        else if (discriminant == 0)
        {
            Console.WriteLine(1);
            double root = -b / (2 * a);
            Console.WriteLine(root.ToString("F6"));
        }
        else
        {
            Console.WriteLine(2);
            double root1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b + Math.Sqrt(discriminant)) / (2 * a);

            if (root1 > root2)
            {
                double temp = root1;
                root1 = root2;
                root2 = temp;
            }

            Console.WriteLine(root1.ToString("F6") + " " + root2.ToString("F6"));
        }
    }
}
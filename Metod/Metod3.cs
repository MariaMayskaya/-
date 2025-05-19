using System;

class Program
{
    static int Factorial(int n)
    {
        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine(Factorial(5)); 
        Console.WriteLine(Factorial(3)); 
    }
}
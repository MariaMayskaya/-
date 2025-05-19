using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 5, 7, 2, 8, 1, 4 };
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i]; 
            }
        }
        Console.WriteLine($"Максимальный элемент в массиве: {max}");
    }
}
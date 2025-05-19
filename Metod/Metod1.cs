using System;
class Program
{
    static void Main(string[] args)
    {

        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = Sum(numbers);
        Console.WriteLine($"Сумма чисел в массиве: {sum}");
    }

    static int Sum(int[] numbers)
    {
        int total = 0; 
        foreach (int number in numbers) 
        {
            total += number; 
        }
        return total; // Возврат суммы
    }
}
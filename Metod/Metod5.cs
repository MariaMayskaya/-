using System;
class Program
{
    static void Main(string[] args)
    {

        int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };

        // Массив для хранения уникальных значений
        int[] uniqueNumbers = new int[numbers.Length];
        int uniqueCount = 0;
        // Удаление дубликатов
        for (int i = 0; i < numbers.Length; i++)
        {
            bool duplicate = false;

            for (int j = 0; j < uniqueCount; j++)
            {
                if (numbers[i] == uniqueNumbers[j])
                {
                    duplicate = true;
                    break;
                }
            }

            if (!duplicate)
            {
                uniqueNumbers[uniqueCount++] = numbers[i];
            }
        }
        Console.WriteLine("Массив без дубликатов: {uniqueNumbers}, {uniqueCount}  ));
    }
}

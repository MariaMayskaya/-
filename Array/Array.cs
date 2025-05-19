//Вопрос 1: 18
//Вопрос 2: 2 тк запятая в int[,] указывает на двумерный массив.

//Вопрос 3: Программа завершится с ошибкой (IndexOutOfRangeException). Вы пытаетесь обратиться к элементу nums[3][2], но массив nums имеет только 3 элемента (индексы 0, 1, 2).
//Вопрос 4: nums[2][1]. nums[2] обращается к третьему элементу массива nums (который сам является массивом { 6, 7, 8, 9, 10 }), а nums[2][1] обращается ко второму элементу этого внутреннего массива (индекс 1), который равен 7.


using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[,,] mas = { { { 1, 2 }, { 3, 4 } },
                       { { 4, 5 }, { 6, 7 } },
                       { { 7, 8 }, { 9, 10 } },
                       { { 10, 11 }, { 12, 13 } }
                     };

        for (int i = 0; i < mas.GetLength(0); i++)
        {
            Console.Write("{{");
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                Console.Write("{");
                for (int k = 0; k < mas.GetLength(2); k++)
                {
                    Console.Write(mas[i, j, k]);
                    if (k < mas.GetLength(2) - 1)
                    {
                        Console.Write(" , ");
                    }
                }
                Console.Write("}");
                if (j < mas.GetLength(1) - 1)
                {
                    Console.Write(" , ");
                }
            }
            Console.Write("}}");
            if (i < mas.GetLength(0) - 1)
            {
                Console.Write(" , ");
            }
        }
    }
}

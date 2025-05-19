//1) B
//2) A
//3) B
//4) B
//5) A
//6) A
//7) A

//1.
// using System;
// class Program
// {
//     static void Main(string[] args)
//     {

//         int[] numbers = { 1, 2, 3, 4, 5 };
//         int sum = Sum(numbers);
//         Console.WriteLine($"Сумма чисел в массиве: {sum}");
//     }

//     static int Sum(int[] numbers)
//     {
//         int total = 0; 
//         foreach (int number in numbers) 
//         {
//             total += number; 
//         }
//         return total; // Возврат суммы
//     }
// }


// 2.
// using System;

// class Program
// {
//     static void Main()
//     {
//         string word = "ЛИХАЧИ НА ВСЕХ НАЧИХАЛИ";
//         string cleanWord = word.ToLower().Replace(" ", "");
//         string reversed = "";
//         // Создаем перевернутую строку
//         for (int i = cleanWord.Length - 1; i >= 0; i--)
//         {
//             reversed += cleanWord[i];
//         }

//         bool isPalindrome = cleanWord == reversed;

//         Console.WriteLine($"Слово '{word}' палиндром: {isPalindrome}");
//     }
// }


// 3.
// using System;

// class Program
// {
//     static int Factorial(int n)
//     {
//         int result = 1;
//         for (int i = 2; i <= n; i++)
//         {
//             result *= i;
//         }
//         return result;
//     }
//     static void Main()
//     {
//         Console.WriteLine(Factorial(5)); 
//         Console.WriteLine(Factorial(3)); 
//     }
// }

// 4.
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] numbers = { 3, 5, 7, 2, 8, 1, 4 };
//         int max = numbers[0];
//         for (int i = 1; i < numbers.Length; i++)
//         {
//             if (numbers[i] > max)
//             {
//                 max = numbers[i]; 
//             }
//         }
//         Console.WriteLine($"Максимальный элемент в массиве: {max}");
//     }
// }


// 5.
// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
    
//         int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };

//         // Массив для хранения уникальных значений
//         int[] uniqueNumbers = new int[numbers.Length];
//         int uniqueCount = 0;
//         // Удаление дубликатов
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             bool duplicate = false;

//             for (int j = 0; j < uniqueCount; j++)
//             {
//                 if (numbers[i] == uniqueNumbers[j])
//                 {
//                     duplicate = true;
//                     break;
//                 }
//             }

//             if (!duplicate)
//             {
//                 uniqueNumbers[uniqueCount++] = numbers[i];
//             }
//         }
//         Console.WriteLine("Массив без дубликатов: {uniqueNumbers}, {uniqueCount}  ));
//     }
// }

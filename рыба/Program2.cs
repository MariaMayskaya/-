
//Упражнение 1 (Цикл for)

//using System;
//class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Введите сумму вклада: ");
//        double principal = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Введите количество месяцев: ");
//        int months = Convert.ToInt32(Console.ReadLine());

//        double interestRate = 0.07;

//        double finalAmount = principal;

//        for (int i = 0; i < months; i++)
//        {
//            finalAmount += finalAmount * interestRate;
//        }

//        Console.WriteLine($"Конечная сумма вклада через {months} месяцев составит: {finalAmount:F2}");
//    }
//}



//Упражнение 2 (Цикл while)

//using System;

//using System;
//class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Введите сумму вклада: ");
//        double principal = Convert.ToDouble(Console.ReadLine());

//        Console.Write("Введите количество месяцев: ");
//        int months = Convert.ToInt32(Console.ReadLine());


//        double interestRate = 0.07;
//        double totalAmount = principal;
//        int monthCounter = 0;


//        while (monthCounter < months)
//        {
//            totalAmount += totalAmount * interestRate;
//            monthCounter++;
//        }
//        Console.WriteLine($"Конечная сумма вклада через {months} месяцев: {totalAmount:F2}");
//    }
//}



////Упражнение 3 (Таблица умножения)

//using System;

//public class MultiplicationTable
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Таблица умножения:");
//        for (int i = 1; i <= 10; i++)
//        {
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.Write(i * j + "\t"); 
//            }
//            Console.WriteLine(); 
//        }
//    }
//}


////Упражнение 4 (Проверка диапазона с while и break)

//using System;

//public class MultiplicationRange
//{
//    public static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.WriteLine("Введите первое число (от 0 до 10):");
//            int num1 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Введите второе число (от 0 до 10):");
//            int num2 = Convert.ToInt32(Console.ReadLine());

//            if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
//            {
//                Console.WriteLine("Введенные числа недопустимы. Пожалуйста, попробуйте еще раз.");
//            }
//            else
//            {
//                Console.WriteLine("Результат умножения: " + num1 * num2);
//                break;
//            }
//        }
//    }
//}


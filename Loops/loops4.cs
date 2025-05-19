using System;

public class MultiplicationRange
{
   public static void Main(string[] args)
   {
       while (true)
       {
           Console.WriteLine("Введите первое число (от 0 до 10):");
           int num1 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Введите второе число (от 0 до 10):");
           int num2 = Convert.ToInt32(Console.ReadLine());

           if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
           {
               Console.WriteLine("Введенные числа недопустимы. Пожалуйста, попробуйте еще раз.");
           }
           else
           {
               Console.WriteLine("Результат умножения: " + num1 * num2);
               break;
           }
       }
   }
}
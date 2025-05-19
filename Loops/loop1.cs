using System;
class Program
{
   static void Main(string[] args)
   {

       Console.Write("Введите сумму вклада: ");
       double principal = Convert.ToDouble(Console.ReadLine());

       Console.Write("Введите количество месяцев: ");
       int months = Convert.ToInt32(Console.ReadLine());

       double interestRate = 0.07;

       double finalAmount = principal;

       for (int i = 0; i < months; i++)
       {
           finalAmount += finalAmount * interestRate;
       }

       Console.WriteLine($"Конечная сумма вклада через {months} месяцев составит: {finalAmount:F2}");
   }
}

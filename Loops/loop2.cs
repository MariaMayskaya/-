using System;

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
       double totalAmount = principal;
       int monthCounter = 0;


       while (monthCounter < months)
       {
           totalAmount += totalAmount * interestRate;
           monthCounter++;
       }
       Console.WriteLine($"Конечная сумма вклада через {months} месяцев: {totalAmount:F2}");
   }
}
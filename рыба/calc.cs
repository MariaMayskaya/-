using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            double number1;
            double number2;

            char operation;

            Console.Write("Введите первое число: ");
            string input1 = Console.ReadLine(); 
            number1 = Convert.ToDouble(input1); 

            Console.Write("Введите второе число: ");
            string input2 = Console.ReadLine(); 
            number2 = Convert.ToDouble(input2); 
  
            Console.Write("Выберите операцию (+, -, *, /, %): ");
            operation = Convert.ToChar(Console.ReadLine()); 

            double result = 0; 

            if (operation == '+')
            {
                result = number1 + number2;
            }
            if (operation == '-')
            {
                result = number1 - number2;
            }
            if (operation == '*')
            {
                result = number1 * number2;
            }
            if (operation == '/')
            {
                result = number1 / number2; 
            }
            if (operation == '%')
            {
                result = number1 % number2;  
            }

            Console.WriteLine("Результат: " + result);

        }
    }
}

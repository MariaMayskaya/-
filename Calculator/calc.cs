using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char operation;
            bool error = false;

            Console.Write("Выберите операцию (+, -, *, /, %, i (инкремент), d (декремент)): ");
            operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

           
            if (operation == 'i' || operation == 'd') 
            {
                Console.Write("Введите число: ");
                double number = Convert.ToDouble(Console.ReadLine());

                result = (operation == 'i') ? number + 1 : number - 1;  
                Console.WriteLine($"Результат: {(operation == 'i' ? "Инкремент" : "Декремент")} {number} = {result}"); 
                return; 
            }

            if (operation != '+' && operation != '-' && operation != '*' && operation != '/' && operation != '%')  
            {
                Console.WriteLine("Неизвестная операция! Доступные операции: + - * / % i d"); 
                return;
            }

            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

          
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
                if (number2 == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно!");
                    error = true;
                }
                else
                {
                    result = number1 / number2;
                }
            }
            if (operation == '%')
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Ошибка: невозможно вычислить остаток от деления на ноль!");
                    error = true;
                }
                else
                {
                    result = number1 % number2;
                }
            }


            if (!error)
            {
                Console.WriteLine($"Результат: {number1} {operation} {number2} = {result}");
            }
        }
    }
}

## ДЗ C#

### Steck

##<p>Задание 1</p>
[ссылка на дз](https://github.com/MariaMayskaya/-/blob/main/%D1%80%D1%8B%D0%B1%D0%B0/Program1.cs)

1.Программа завершит выполнение с ошибкой.В C# имена переменных чувствительны к регистру. переменная name(с маленькой буквы), а пытаются вывести Name(с большой буквы).
2. Sam.Переменная person сначала инициализируется значением “Tom”, а затем ей присваивается новое значение “Sam”.
3.  string person = "Том";
string person;
1)НЕ являются встроенными типами C# :real, int128, float64
2) bool
3) float
4)4 байта
5) Корректное определение переменных :string person = "Tom";var person = "Tom";string person;

<p>Практическое задание </p>
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Введите ФИО:");
            string fullName = Console.ReadLine();

            Console.WriteLine("Введите возраст:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("На кого учитесь:");
            string major = Console.ReadLine();

            Console.WriteLine("Получаете стипендию? :");
            string scholarshipInput = Console.ReadLine();

            Console.WriteLine("Оценка по Русскому:");
            double russianGrade = double.Parse(Console.ReadLine());

            Console.WriteLine("Оценка по Математике:");
            double mathGrade = double.Parse(Console.ReadLine());


            Console.WriteLine("ФИО: " + fullName);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Учится на: " + major);
            Console.WriteLine("Получает стипендию: " + scholarshipInput);
            Console.WriteLine("Оценка по Русскому: " + russianGrade);
            Console.WriteLine("Оценка по Математике: " + mathGrade);
        }
    }
}



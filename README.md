## ДЗ 

### Steck

##Вопрос 1
Сколько элементов имеет следующий массив? 1 int[,,] numbers = new int[3, 2, 3]; Варианты ответов
0
1
8
9
11 6. 18

##Вопрос 2
Сколько измерений (размерность) имеет следующий массив? 1 int[,] numbers = new int[3, 3]; Варианты ответов
1 2. 2
3
6
Вопрос 3
Что будет выведено на консоль в результате выполнения следующего кода: 1 2 3 4 5 6

int[][] nums = new int[3][];
nums[0] = new int[2] { 1, 2 };
nums[1] = new int[3] { 3, 4, 5 }; 
nums[2] = new int[5] { 6, 7, 8, 9, 10 };
 
Console.WriteLine(nums[3][2]);
Вопрос 4
Дан следующий массив

int[][] nums = new int[3][];
nums[0] = new int[2] { 1, 2 };
nums[1] = new int[3] { 3, 4, 5 }; 
nums[2] = new int[5] { 6, 7, 8, 9, 10 };
Каким образом мы можем обратиться к числу 7 в этом массиве? Варианты ответов

nums[7]
nums[2, 1] 3. nums[2][1]
nums[3]
nums[3, 3]
nums[3][3]
Практические вопросы
Упражнение 1
Задан следующий трехмерный массив:

int[,,] mas = { { { 1, 2 },{ 3, 4 } }, { { 4, 5 }, { 6, 7 } }, { { 7, 8 }, { 9, 10 } }, { { 10, 11 }, { 12, 13 } } }; С помощью циклов переберите все элементы этого массива и выведите их на консоль в следующем виде:

{{{1 , 2} , {3 , 4}} , {{4 , 5} , {6 , 7}} , {{7 , 8}, {9 , 10}} , {{10 , 11} , {12 , 13}}}

using System; class Program { int void main ([] args) { int[,,] mas = { { { 1, 2 },{ 3, 4 } }, { { 4, 5 }, { 6, 7 } }, { { 7, 8 }, { 9, 10 } }, { { 10, 11 }, { 12, 13 } } }; Console.Write()

} }


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



using System;

class Program
{
    static void Main()
    {
        string word = "ЛИХАЧИ НА ВСЕХ НАЧИХАЛИ";
        string cleanWord = word.ToLower().Replace(" ", "");
        string reversed = "";
        // Создаем перевернутую строку
        for (int i = cleanWord.Length - 1; i >= 0; i--)
        {
            reversed += cleanWord[i];
        }

        bool isPalindrome = cleanWord == reversed;

        Console.WriteLine($"Слово '{word}' палиндром: {isPalindrome}");
    }
}
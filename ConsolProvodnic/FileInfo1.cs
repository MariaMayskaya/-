using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string currentPath = Directory.GetCurrentDirectory();
        while (true)
        {
            Console.WriteLine($"\nТекущий каталог: {currentPath}");
            ListDirectory(currentPath);

            Console.Write("\nВведите команду (open, mkdir, touch, rm, cd, exit): ");
            string command = Console.ReadLine().Trim().ToLower();

            switch (command)
            {
                case "open":
                    await OpenFile(currentPath);
                    break;

                case "mkdir":
                    CreateDirectory(currentPath);
                    break;

                case "touch":
                    await CreateFile(currentPath);
                    break;

                case "rm":
                    DeleteItem(currentPath);
                    break;

                case "cd":
                    currentPath = ChangeDirectory(currentPath);
                    break;

                case "exit":
                    Console.WriteLine("Выход из приложения.");
                    return;

                default:
                    Console.WriteLine("Неизвестная команда. Пожалуйста, попробуйте снова.");
                    break;
            }
        }
    }

    static void ListDirectory(string path)
    {
        try
        {
            string[] items = Directory.GetFileSystemEntries(path);
            Console.WriteLine("Содержимое каталога:");
            foreach (string item in items)
            {
                Console.WriteLine(Path.GetFileName(item));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при доступе к каталогу: {e.Message}");
        }
    }

    static async Task OpenFile(string path)
    {
        Console.Write("Введите имя файла для открытия: ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(path, fileName);

        try
        {
            if (File.Exists(filePath))
            {
                string content = await File.ReadAllTextAsync(filePath, Encoding.UTF8);
                Console.WriteLine("\nСодержимое файла:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("Файл не существует.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при открытии файла: {e.Message}");
        }
    }

    static void CreateDirectory(string path)
    {
        Console.Write("Введите имя нового каталога: ");
        string dirName = Console.ReadLine();
        string dirPath = Path.Combine(path, dirName);

        try
        {
            Directory.CreateDirectory(dirPath);
            Console.WriteLine($"Каталог '{dirName}' успешно создан.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при создании каталога: {e.Message}");
        }
    }

    static async Task CreateFile(string path)
    {
        Console.Write("Введите имя нового файла: ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(path, fileName);

        Console.Write("Введите содержимое файла: ");
        string content = Console.ReadLine();

        try
        {
            await File.WriteAllTextAsync(filePath, content, Encoding.UTF8);
            Console.WriteLine($"Файл '{fileName}' успешно создан.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка при создании файла: {e.Message}");
        }
    }

    static void DeleteItem(string path)
    {
        Console.Write("Введите имя файла или каталога для удаления: ");
        string itemName = Console.ReadLine();
        string itemPath = Path.Combine(path, itemName);

        Console.Write($"Вы уверены, что хотите удалить '{itemName}'? (y/n): ");
        if (Console.ReadLine().Trim().ToLower() == "y")
        {
            try
            {
                if (Directory.Exists(itemPath))
                {
                    Directory.Delete(itemPath, true);
                }
                else if (File.Exists(itemPath))
                {
                    File.Delete(itemPath);
                }
                else
                {
                    Console.WriteLine("Такого файла или каталога не существует.");
                    return;
                }
                Console.WriteLine($"'{itemName}' успешно удален.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при удалении: {e.Message}");
            }
        }
    }

    static string ChangeDirectory(string currentPath)
    {
        Console.Write("Введите имя подкаталога для перехода: ");
        string dirName = Console.ReadLine();
        string newPath = Path.Combine(currentPath, dirName);

        if (Directory.Exists(newPath))
        {
            return newPath;
        }
        else
        {
            Console.WriteLine("Такого каталога не существует.");
            return currentPath;
        }
    }
}

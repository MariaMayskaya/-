using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Просмотр доступных дисков
            Console.WriteLine("Доступные диски:");
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {drives[i].Name}");
            }

            Console.Write("Выберите диск (введите номер) или 'exit' для выхода: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out int driveIndex) && driveIndex > 0 && driveIndex <= drives.Length)
            {
                DriveInfo selectedDrive = drives[driveIndex - 1];
                ManageDrive(selectedDrive);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, попробуйте снова.");
            }
        }
    }

    static void ManageDrive(DriveInfo drive)
    {
        Console.WriteLine($"\nИнформация о диске {drive.Name}:");
        Console.WriteLine($"Объем: {drive.TotalSize / (1024 * 1024 * 1024)} ГБ");
        Console.WriteLine($"Доступно: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} ГБ");
        Console.WriteLine($"Файловая система: {drive.DriveFormat}");

        while (true)
        {
            Console.WriteLine($"\nСодержимое диска {drive.Name}:");
            ListDirectory(drive.RootDirectory.FullName);

            Console.Write("\nВведите команду (mkdir, touch, rm, exit): ");
            string command = Console.ReadLine().Trim().ToLower();

            switch (command)
            {
                case "mkdir":
                    CreateDirectory(drive.RootDirectory.FullName);
                    break;

                case "touch":
                    CreateFile(drive.RootDirectory.FullName);
                    break;

                case "rm":
                    DeleteItem(drive.RootDirectory.FullName);
                    break;

                case "exit":
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

    static void CreateFile(string path)
    {
        Console.Write("Введите имя нового текстового файла: ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(path, fileName);

        Console.Write("Введите содержимое файла: ");
        string content = Console.ReadLine();

        try
        {
            File.WriteAllText(filePath, content);
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
}

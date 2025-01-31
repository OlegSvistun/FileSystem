using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введіть шлях до вихідного файлу: ");
            string sourcePath = Console.ReadLine();

            Console.Write("Введіть шлях до файлу призначення: ");
            string destinationPath = Console.ReadLine();

            if (sourcePath == null || sourcePath == "" || !File.Exists(sourcePath))
            {
                Console.WriteLine("Помилка: Невірний шлях до вихідного файлу або файл не існує!");
                return;
            }

            if (destinationPath == null || destinationPath == "")
            {
                Console.WriteLine("Помилка: Невірний шлях до файлу призначення!");
                return;
            }

            string content = File.ReadAllText(sourcePath);
            File.WriteAllText(destinationPath, content);
            Console.WriteLine("Вміст файлу успішно скопійовано!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }

        Console.WriteLine("Натисніть Enter для виходу...");
        Console.ReadLine();
    }
}
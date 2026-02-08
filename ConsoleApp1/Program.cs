using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        const string KEY = "Z";

        static void Main()
        {
            Console.Title = "ConsoleApp1";
            Console.WriteLine("**** PROGRAM ****\n");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Welcome, {name}!");

            Console.Write("Key: ");
            string userInput = Console.ReadLine();

            if (userInput == KEY)
            {
                Console.WriteLine("Ключ верный!\n");
                MainMenu();
            }
            else
            {
                Console.WriteLine("Неверный ключ!");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n----- Main Menu -----");
                Console.WriteLine("1 - Калькулятор");
                Console.WriteLine("2 - Информация");
                Console.WriteLine("3 - Выход");
                Console.Write("Выбор: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Введите число!");
                    continue;
                }

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        Calculator();
                        break;

                    case 2:
                        ShowInfo();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Неверный пункт меню!");
                        break;
                }
            }
        }

        static void Calculator()
        {
            Console.WriteLine("=== Калькулятор ===");

            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Ошибка ввода!");
                return;
            }

            Console.Write("Оператор (+ - * /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Ошибка ввода!");
                return;
            }

            double result;

            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Деление на ноль!");
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Неизвестный оператор!");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }

        static void ShowInfo()
        {
            Console.WriteLine("=== Информация ===");
            Console.WriteLine("© SteelFoxGames");
            Console.WriteLine("Версия: 1.0");
            Console.WriteLine("Год: 2026");
        }

        static void GoldBuy()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "hacked.txt");
            File.WriteAllText(filePath, "BUY GOLD BUY GOLD BUY GOLD");
        }
    }
}

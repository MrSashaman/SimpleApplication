
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            string name = "";
            string key = "Z";
            string userinput = "";
            Console.WriteLine("****PROGRAM****");
            Console.WriteLine("");

            Console.Write("Name: ");
            name = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("Welcome! " + name);
            
            Console.Write("Key: ");
            userinput = Convert.ToString(Console.ReadLine());
            
            if (userinput == key) 
            {
                System.Console.WriteLine("Ключ верный!");
                KeyCorrect();
            }

            else
            {
                System.Console.WriteLine("Неверный ключ!");
                Console.ReadLine();
                Console.Clear();
                
            }
            Console.ReadKey();

        }
        
        static void GoldBuy()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = "hacked.txt";
            string filePath = Path.Combine(desktopPath, fileName);
            File.WriteAllText(filePath, "BUY GOLDBUY GOLDBUY GOLDBUY GOLDBUY GOLDBUY GOLDBUY GOLDBUY GOLD");

            Console.Write("ERROR");
        }
        
        static void KeyCorrect()
        {
            while (true)
            {
                Console.WriteLine("-----MainMenu-----");
                Console.WriteLine("1 - Калькулятор");
                Console.WriteLine("2 - Информация");

                if (!int.TryParse(Console.ReadLine(), out int userinput))
                {
                    Console.WriteLine("Введите число!");
                    continue;
                }

                if (userinput == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Калькулятор");
                    break;
                }
                else if (userinput == 2)
                {
                    Console.WriteLine("Информация");
                    Console.WriteLine("©SteelFoxGames - 2026");
                    break;
                }
                else
                {
                    Console.WriteLine("Ввод неверный! Используйте: 1 или 2");
                }
            }
        }


    }
}

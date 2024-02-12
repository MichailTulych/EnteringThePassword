using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnteringThePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triesCount = 3;
            string password = "14638a@7";
            string userInput;

            for (int i = 1; i <= triesCount; i++)
            {
                Console.WriteLine("ВВедите пароль: ");
                userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else Console.WriteLine($"Вы ввели неверный пароль. У вас осталось попыток: {triesCount - i}");
            }
            Console.ReadKey();
        }
    }
}

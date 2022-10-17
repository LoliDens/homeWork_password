using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = "Египетская сила";
            string secretPassword = "1234";
            int amoutTry = 3;
            int numberTry = 0; 
            string userInput = null;

            for (int i = amoutTry; i >= numberTry; i--) 
            {
                Console.WriteLine("Введите пароль, чтобы получить доступ к информации");
                userInput = Console.ReadLine();

                if (userInput == secretPassword)
                {
                    Console.WriteLine($"Секретно сообщение: {secretMessage}");
                    Console.ReadKey();
                    numberTry = amoutTry;
                }
                else 
                {
                    Console.WriteLine($"у вас осталось {i} попытки");
                }
            } 
        }
    }
}

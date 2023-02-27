using System;

namespace Project02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Duck Park!");
            int number = 12;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Нас уже ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(number);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" человек!");
            Console.WriteLine("Будем рады видеть вас.");
            Console.WriteLine("Приложение находиться в разработке.");
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Привет учитель! {name}");
            Console.ResetColor();
            Console.WriteLine("Нажмите любую кнопку чтобы выйти…");
            Console.ReadLine();
        }
    }
}
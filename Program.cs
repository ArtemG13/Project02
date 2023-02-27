using System;

namespace Project02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Duck Park!");
            Console.ForegroundColor = ConsoleColor.Red; // Так и не понял как покрасить конкретное число :( //
            int number = 12;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Нас уже {number} человек!");
            Console.WriteLine("Будем рады видеть вас.");
            Console.WriteLine("Приложение находиться в разработке.");
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Привет учитель! {name}");
            Console.ResetColor();
        }
    }
}
using System;

namespace Seminar9_63
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 63: Задайте значение N. Напишите программу, которая выведет все 
            натуральные числа в промежутке от 1 до N.
            N = 5 -> "1, 2, 3, 4, 5"
            N = 6 -> "1, 2, 3, 4, 5, 6"
            */
            int GetUserInt(string message)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine (message);
                Console.ResetColor();
                int userInt = Convert.ToInt32(Console.ReadLine());
                return userInt;
            }
            int startIndex = GetUserInt ("Введите максимальный элемент ряда: ");
            Console.WriteLine();
            PrintRange (startIndex);
            Console.WriteLine();

            void PrintRange (int index)
            {
                if (index != 0)
                {
                    PrintRange(index-1);
                    Console.Write(index + ", ");
                }
            }

        }
    }
}

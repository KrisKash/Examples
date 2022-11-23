using System;

namespace Seminar3_Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Напишите программу, которая принимает на вход число (N) 
            и выдаёт таблицу квадратов чисел от 1 до N.
            5 -> 1, 4, 9, 16, 25.
            2 -> 1,4
            */

            // int userNumber = new int();
            // userNumber = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(userNumber);

            int getNumberFromUser(string message)
            {
            int result = 0;
            Console.WriteLine(message);
            result = Convert.ToInt32(Console.ReadLine());
            return result;
            }

            int Solution(int userNumber)
            {
                
                for (int i = 1; i <= userNumber; i++)
                {
                    double Numb = Math.Pow(i, 2);
                    Console.WriteLine($"{Numb}");
                    
                }
                return userNumber;
                
            }
            int userNumber = getNumberFromUser("Введите число:");
            Console.WriteLine();
            double Numb = Solution(userNumber);
            Console.WriteLine($"Таблица квадратов чисел от 1 до {userNumber}");
        }
    }
}

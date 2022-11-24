using System;

namespace Seminar4_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 24: Напишите программу, которая принимает на вход число (А) 
            и выдаёт сумму чисел от 1 до А.
            7 -> 28
            4 -> 10
            8 -> 36
            */

            int SumOfRange(int start, int finish)
            {
                int sum = 0;
                for (int i = start; i <= finish; i++)
                {
                    sum += i;
                }
                return sum;
            }

            int getNumberFromUser(string message)
            {
                int result = 0;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(message);
                Console.ResetColor();
                result = Convert.ToInt32(Console.ReadLine());
                return result;
            }
            int userNumber = getNumberFromUser("Введите А для подсчета суммы 1...А");
            int sum = SumOfRange(1, userNumber);
            Console.WriteLine($"Сумма чисел от 1 до {userNumber} = {sum}" );
        }
    }
}

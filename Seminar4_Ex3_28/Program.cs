using System;

namespace Seminar4_Ex3_28
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Задача 28: Напишите программу, которая принимает на вход число N 
            и выдаёт произведение чисел от 1 до N.
            4 -> 24 
            5 -> 120
            
            1 ВАРИАНТ

            int MultOfRange(int start, int finish)
            {
                int mult = 1;
                for (int i = start; i <= finish; i++)
                {
                    mult *= i;
                }
                return mult;
            }

            int getnumberFromUser(string message)
            {
                int result = 0;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(message);
                Console.ResetColor();
                result = Convert.ToInt32(Console.ReadLine());
                return result;
            }
            int usernumber = getnumberFromUser("Введите А для подсчета произведения 1...А");
            int mult = MultOfRange(1, usernumber);
            Console.WriteLine($"Произведение чисел от 1 до {usernumber} = {mult}" );
            */

            Console.Write("Введите число: ");
            Console.WriteLine();
            string writeN = Console.ReadLine();
            int N = Convert.ToInt32(writeN);

            int GetFactorial(int N)
            {
                int Factorial = 1;
                for (int num = 1; num <= N; num++)
                {
                    Factorial = Factorial * num;
                }
                return Factorial;
            }
            
            Console.WriteLine($"Произведение чисел от 1 до {N} = {GetFactorial(N)}");
            Console.WriteLine();

        }
    }
}

using System;

namespace Seminar9_65
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
            все натуральные числа в промежутке от M до N.
            M = 1; N = 5 -> "1, 2, 3, 4, 5"
            M = 4; N = 8 -> "4, 6, 7, 8"
        
            int GetUserInt(string message)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine (message);
                Console.ResetColor();
                int userInt = Convert.ToInt32(Console.ReadLine());
                return userInt;
            }
            

            int PrintRange (int M, int N)
            {
                if (M == N)
                {
                    return M;
                }
                else if (M <= N)
                {
                    PrintRange(M-1,N);
                    Console.Write(M + ", ");
                }
                return PrintRange(M,N);
            }

            int startIndexM = GetUserInt ("Введите число М: ");
            int startIndexN = GetUserInt ("Введите число N: ");
            Console.WriteLine();
            PrintRange (startIndexM, startIndexN);
            Console.WriteLine(); */
            string ResultNumber(int M, int N) 
            { 
                if (N == M) 
                { 
                    return $"{M}"; 
                } 
                return ResultNumber(M, N - 1) + ", " + Convert.ToString(N); 
            } 
            Console.Write("Enter the first number: "); 
            int M = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter the second number: "); 
            int N = Convert.ToInt32(Console.ReadLine()); 
            if (M > N) 
            { 
                Console.WriteLine(ResultNumber(N, M)); 
            } 
            else 
            { 
                Console.WriteLine(ResultNumber(M, N)); 
            }
        }
    }
}

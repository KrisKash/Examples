using System;

namespace Seminar9_69
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 69: Напишите программу, которая на вход принимает 
            два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
            A = 3; B = 5 -> 243 (3⁵)
            A = 2; B = 3 -> 8
            */
            Console.Write("Enter the first number: "); 
            int A = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter the second number: "); 
            int B = Convert.ToInt32(Console.ReadLine()); 
            int squareUserNumber = SquareUserNumber (A,B);
            Console.WriteLine($"Число {A} , возведенное в степнь {B} = {squareUserNumber} ");

            int SquareUserNumber (int A, int B)
            {
                if (B == 0)
                {
                   return 1; 
                }
                return SquareUserNumber (A, B-1) * A;
            }
        }
    }
}

using System;

namespace Seminar2_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, которая выводит случайное число из отрезка
            [10,99] и показывает наибольшую цифру числа*/
            int GetRandomNumberInRange(int start, int end)
            {
                int result = 0;
                result = new Random().Next(start, end + 1);
                return result;
            }
            int GetMaxDigitFromNumber(int number)
            {
                int max = number / 10;
                int secondDigit = number % 10;
                if (secondDigit > max)
                {
                    max = secondDigit;
                }
                return max;
            }
            int randomNumber = GetRandomNumberInRange(10, 99);
            int maxDigit = GetMaxDigitFromNumber(randomNumber);
            Console.WriteLine($"Для числа {randomNumber} большей цифрой является {maxDigit}");
        }
    }
}


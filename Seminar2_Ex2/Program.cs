using System;

namespace Seminar2_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Напишите программу, которая выводит случайное трехзначное число 
            и удаляет вторую цифру этого числа.
            456 -> 46
            782 -> 72
            918 -> 98
            */
            int GetRandomNumber(int start, int end)
            {
                int result = 0;
                result = new Random().Next(start, end + 1);
                return result;
            }
            int GetFirstLastNumber (int RandomNumber)
            {
                int number1 = RandomNumber / 100;
                int number3 = RandomNumber % 10;
                int number = (number1 * 10) + number3;
                return number;
            }
            int RandomNumber = GetRandomNumber(100, 999);
            int number = GetFirstLastNumber(RandomNumber);
            Console.WriteLine($"После удаления второй цифры из числа {RandomNumber}, получается число {number}");
        }
    }
}

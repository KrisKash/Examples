using System;

namespace Seminar6_Ex44
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
            Первые два числа Фибоначчи: 0 и 1.
            Если N = 5 -> 0 1 1 2 3
            Если N = 3 -> 0 1 1
            Если N = 7 -> 0 1 1 2 3 5 8
            */
            Console.WriteLine("Введите число");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int[] fibArray = fillingArray(userNumber);
            printArray(fibArray);


            int[] fillingArray(int number)
            {
                int[] fibonachiArray = new int[number];
                fibonachiArray[0] = 0;
                fibonachiArray[1] = 1;
                for (int i = 2; i < number; i++)
                {
                    fibonachiArray[i] = fibonachiArray[i - 2] + fibonachiArray[i - 1];
                }
                return fibonachiArray;
            }

            void printArray(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i < array.Length - 1) 
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
            }
        }
    }
}

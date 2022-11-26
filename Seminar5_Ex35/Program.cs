using System;

namespace Seminar5_Ex35
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 35: Задайте одномерный массив из 123 случайных чисел. 
            Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
            Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
            [5, 18, 123, 6, 2] -> 1
            [ 1, 2, 3, 6,2] -> 0
            [10, 11, 12, 13, 14] -> 5
            */
            int[] GenerateRandomArray(int length, int min, int max)
            {
                int [] array = new int [length];
                for (int i = 0; i < length; i++)
                {
                    array[i] = new Random().Next(min, max+1);
                }
                return array;
            }

            void PrintArray(int [] array)
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

            int AmountOfNumbers (int [] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 9 && array[i] < 100)
                    {
                        count++;
                    }
                }
                return count;
            }

            int [] array = GenerateRandomArray(123, -100, 100);
            PrintArray(array);
            int count = AmountOfNumbers(array);
            if (count > 0)
            {
                Console.WriteLine($"Число элементов из интервала [10,99] равно {count}");  
            }
            else
            {
                Console.WriteLine("Элементов нет");
            }
            
        }
    }
}

using System;

namespace Seminar5_Ex32
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 32: Напишите программу замена элементов массива: положительные элементы 
            замените на соответствующие отрицательные, и наоборот.
            [-4, -8, 8, 2] -> [4, 8, -8, -2]
            */

            int[] GenerateRandomArray(int length, int startPoint, int endPoint)
            {
                int [] resultArray = new int [length];
                for (int i = 0; i < length; i++)
                {
                    resultArray[i] = new Random().Next(startPoint, endPoint+1);
                }
                return resultArray;
            }

            int [] InverseArray(int [] array)
            {
                
                for (int i = 0; i < array.Length; i++)
                {
                    array [i] = -array[i];
                }
                return array;                
            }

                        
            void PrintArray(int [] array, string NameOfArray)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"------{NameOfArray}-------- ");
                Console.ResetColor();
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

            int [] array = GenerateRandomArray(10, -100, 100);
            PrintArray(array, "Исходный массив");
            Console.WriteLine();
            int [] InverstedArray = InverseArray(array);
            PrintArray(array, "Инвертированный массив");
            
        }
    }
}

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

            int GetReplacementElement(int [] array)
            {
                int element = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    element = element * i;
                    resultArray = array[element[i]];
                }
                return resultArray;                
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

            int [] array = GenerateRandomArray(4, -9, 9);
            PrintArray(array);
            Console.WriteLine();
            int resultArray = GetReplacementElement(array);
            Console.Write($" {array} => {resultArray},");
            Console.WriteLine();
        }
    }
}

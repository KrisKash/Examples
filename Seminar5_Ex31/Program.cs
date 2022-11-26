using System;

namespace Seminar5_Ex31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
            из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов
            массива.
            Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
            равна 29, сумма отрицательных равна -20.
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

            int GetSumOfPositiveElementsArray(int [] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        sum += array[i];
                    }
                }
                return sum;                
            }

            int GetSumOfNegativeElementsArray(int [] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        sum += array[i];
                    }
                }
                return sum;                
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

            int [] array = GenerateRandomArray(12, -9, 9);
            PrintArray(array);
            Console.WriteLine();
            int sumOfPositive = GetSumOfPositiveElementsArray(array);
            int sumOfNegative = GetSumOfNegativeElementsArray (array);
            Console.Write($"Сумма положительных чисел данного массива = {sumOfPositive},");
            Console.WriteLine($"а сумма отрицательных чисел = {sumOfNegative} ");
            Console.WriteLine();
        }
    }
}

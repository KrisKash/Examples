using System;

namespace Seminar5_Ex37
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
            Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
            Результат запишите в новом массиве.
            [1 2 3 4 5] -> 5 8 3
            [6 7 3 6] -> 36 21           
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

            int FindMultArray (int [] multArray)
            {                
                int [] newArray = new int[newLength];
                if (length % 2 == 0)
                {
                    newLength = length / 2;
                }
                else
                {
                    newLength = (length + 1) / 2;  
                }
                
                
                for (int i = 0; i < newLength; i++)
                {
                    newArray[i] = array[i] * array[length - 1 - i];
                }
                
                return newArray;
            }

            int [] array = GenerateRandomArray(6, 0, 10);
            PrintArray(array);
            int [] newArray = FindMultArray(array);
            PrintArray (newArray);
        }
    }
}

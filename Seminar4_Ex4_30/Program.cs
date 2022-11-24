using System;

namespace Seminar4_Ex4_30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Напишите программу, которая выводит массив из 8 элементов, 
            заполненный нулями и единицами в случайном порядке.
            [1,0,1,1,0,1,0,0]
             
            1 ВАРИАНТ

            int[] CreateArray(int N, int min, int max)
            {
                int[] arr = new int[N];
                for (int i = 0; i < N; i++)
                {
                    arr[i] = new Random().Next(min, max + 1);
                }
                return arr;
            }

            void PrintArray(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]}");
                    Console.Write(" ");
                }
                Console.WriteLine("]");
            }

            int N = 8;
            int min = 0;
            int max = 1;
            int[]Array = CreateArray(N, min, max);
            PrintArray(Array);
            */

            int[] getRange(int length)
            {
                int [] array = new int [length];
                Random rd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rd.Next(0, 2);
                }
                return array;
            }

            void printArray(int [] array)
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

            int [] array = getRange(8);
            printArray(array);
        }
    }
}

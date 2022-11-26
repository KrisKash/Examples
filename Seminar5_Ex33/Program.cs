using System;

namespace Seminar5_Ex33
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 33: Задайте массив. Напишите программу, которая определяет, 
            присутствует ли заданное число в массиве.
            4; массив [6, 7, 19, 345, 3] -> нет
            -3; массив [6, 7, 19, 345, 3] -> да
            */
            int[] GenerateRandomArray(int length, int startPoint, int endPoint)
            {
                int [] array = new int [length];
                for (int i = 0; i < length; i++)
                {
                    array[i] = new Random().Next(startPoint, endPoint+1);
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
            bool FindNumber (int [] array, int find)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == find) return true;
                }
                return false;
            }

            Console.WriteLine("Введите искомое число в массиве:");
            int find = int.Parse(Console.ReadLine());
            int [] array = GenerateRandomArray(10, -10, 10);
            PrintArray(array);
            FindNumber (array, find);
            if (FindNumber (array, find))
            {
                Console.WriteLine($"{find} присутствует  в массиве ");
            }
            else
            {
                Console.WriteLine($"{find}  отсутствует в массиве ");
            }
            



        }
    }
}

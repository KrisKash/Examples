using System;

namespace Seminar7_Ex46
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 46: Задайте двумерный массив размером m×n, заполненный 
            случайными целыми числами.
            m = 3, n = 4.
            1 4 8 19
            5 -2 33 -2
            77 3 8 1
            */
            int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
            {
                int[,] array = new int[lengthRow,lengthCol];
                for (int i = 0; i < lengthRow; i++)
                {
                    for (int j = 0; j < lengthCol; j++)
                    {
                        array[i,j] = new Random().Next(-deviation,deviation +1);
                    }
                }
                return array;
            }
            void printColor(string information, ConsoleColor color)
            {
                Console.ForegroundColor = color;
                Console.Write(information);
                Console.ResetColor();
            }
            void print2dArray(int[,] array)
            {
                Console.Write("\t");
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    printColor(i + "\t",ConsoleColor.DarkYellow);
                }
                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    printColor(i+"\t",ConsoleColor.DarkYellow);
                    for (int j = 0; j <  array.GetLength(1); j++)
                    {
                        Console.Write(array[i,j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            int[,] array = generate2DArray(5,7,100);
            print2dArray(array);
        }
    }
}

using System;

namespace Seminar8_Ex57
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 57: Составить частотный словарь элементов двумерного массива. 
            Частотный словарь содержит информацию о том, сколько раз встречается элемент 
            входных данных.
            Набор данных
            Частотный массив
            { 1, 9, 9, 0, 2, 8, 0, 9 }
            0 встречается 2 раза
            1 встречается 1 раз
            2 встречается 1 раз
            8 встречается 1 раз
            9 встречается 3 раза
            1, 2, 3
            4, 6, 1
            2, 1, 6
            1 встречается 3 раза
            2 встречается 2 раз
            3 встречается 1 раз
            4 встречается 1 раз
            6 встречается 2 раза
            */
            int[,] Generate2DArray(int lengthRow, int lengthCol, int deviation)
            {
                int[,] array = new int[lengthRow, lengthCol];
                for (int i = 0; i < lengthRow; i++)
                {
                    for (int j = 0; j < lengthCol; j++)
                    {
                        array[i, j] = new Random().Next(-deviation, deviation + 1);
                    }
                }
                return array;
            }
            void printColor(string information, ConsoleColor color, bool newLine = false)
            {
                Console.ForegroundColor = color;
                Console.Write(information);
                Console.ResetColor();
                if (newLine)
                {
                    Console.WriteLine();
                }
            }
            void print2dArray(int[,] array, string Name = "")
            {
                printColor(Name, ConsoleColor.DarkCyan, true);
                Console.Write("\t");
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    printColor(i + "\t", ConsoleColor.DarkYellow,(i >= array.GetLength(1) - 1));
                }
                
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    printColor(i + "\t", ConsoleColor.DarkYellow);
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }
            void NumberOfIdenticalElements (int [,] array, int n)
            {
                int count = 0;
               
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i,j] == n)
                        {
                            count++;
                            array[i,j] = 0;
                        }
                    }
                }
                Console.WriteLine($"Элемент {n} встречается {count} раз");
            }
            void NumberOfIdentical (int [,] array)
            {
               
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i,j] != 0)
                        {
                            NumberOfIdenticalElements (array, array[i,j]);
                        }
                    }
                }
            }
            int [,] array = Generate2DArray(3,4,10);
            print2dArray(array);
            NumberOfIdentical(array);
            
        }
    }
}

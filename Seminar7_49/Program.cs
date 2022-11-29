using System;

namespace Seminar7_49
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача 49: Задайте двумерный массив.
            Найдите элементы, у которых оба индекса чётные,
            и замените эти элементы на их квадраты.
            Например, изначально массив выглядел вот так:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            */

            int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
            {
                int[,] array = new int[lengthRow, lengthCol];
                {
                    for (int i = 0; i < lengthRow; i++)
                    {
                        for(int j = 0; j < lengthCol; j++)
                        {
                            array[i,j] = new Random().Next(-deviation, deviation + 1);
                        }
                    }
                }

                return array;
            }
            void print2dArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            int[,] new2DArraySq(int[,] new2DArray)
            {
                for (int i = 0; i < new2DArray.GetLength(0); i+= 2)
                {
                    for (int j = 0; j < new2DArray.GetLength(1); j+= 2)
                    {
                        new2DArray[i, j] *= new2DArray[i, j];
                    }
                }
                return new2DArray;
            }

            int[,] array = generate2DArray(5,8, 40);
            print2dArray(array);
            Console.WriteLine();
            int[,] new2DArray = new2DArraySq(array);
            print2dArray(new2DArray);
        }
    }
}

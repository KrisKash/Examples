using System;

namespace Seminar7_51
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* Задача 51: Задайте двумерный массив. Найдите Сумму элементов главной диагонали
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            Сумма элементов главной диагонали: 1+9+2 = 12 */

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
            int sumArrayDiag(int[,] new2DArray)
            {
                int sum = 0;
                for (int i = 0; i < new2DArray.GetLength(0); i++)
                {
                    for (int j = 0; j < new2DArray.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            sum = sum + new2DArray[i, j];
                        }
                    }
                }
                return sum;
            }

            int[,] array = generate2DArray(8, 9, 10);
            print2dArray(array);
            Console.WriteLine();
            int sum = sumArrayDiag(array);
            Console.WriteLine($"Сумма элементов главной диагонали равна {sum}.");
        }
    }
}

using System;

namespace Seminar7_52
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
            */

            int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
            {
                int[,] array = new int[lengthRow, lengthCol];
                {
                    for (int i = 0; i < lengthRow; i++)
                    {
                        for (int j = 0; j < lengthCol; j++)
                        {
                            array[i, j] = new Random().Next(-deviation, deviation + 1);
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

            double midSumArray(int[,] new2DArray)
            {
                int sum = 0;
                double midAr = 0;
                for (int j = 0; j < new2DArray.GetLength(1); j++)
                {
                    for (int i = 0; i < new2DArray.GetLength(0); i++)
                    {
                        sum += new2DArray[i, j];
                        midAr = Convert.ToDouble(sum / i);
                        Console.WriteLine($" {midAr} ");
                    }
                
                }
                return midAr;
            }

            int[,] array = generate2DArray(5, 8, 10);
            print2dArray(array);
            Console.WriteLine();
            double midAr = midSumArray(array);
            Console.WriteLine(midAr);
        }
    }
}

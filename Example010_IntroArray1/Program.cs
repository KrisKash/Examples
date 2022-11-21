using System;

namespace Example010_IntroArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18};

            int n = array.Length; //array.Length - длина/количество символов массива
            int find = 18; //число, которое может ввести пользователь

            int index = 0;

            while (index < n)
            {
                if(array[index] == find)
                {
                    Console.WriteLine(index);
                    break; // завершение работы при нахождении первого подходящего значения
                }
                index++; //index = index + 1;
            }

        }
    }
}

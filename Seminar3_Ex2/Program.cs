using System;

namespace Seminar3_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            8 Напишите программу, которая по заданному номеру четверти, 
            показывает диапазон возможных координат точек в этой четверти (x и y).
           */ 
            /*int quater = new int();
            Console.WriteLine("Введите номер четверти: ");
            quater = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{quater}");
            Console.WriteLine();
            */


            int GetCoordinateFromQuater(int quater)
            {
                if (quater == 1)
                {
                    Console.WriteLine("x > 0 и y > 0");
                }
                else if (quater == 2)
                {
                    Console.WriteLine("x < 0 и y > 0");
                }
                else if (quater == 3)
                {
                    Console.WriteLine("x < 0 и y < 0");
                }
                else if (quater == 4)
                {
                    Console.WriteLine("x > 0 и y < 0");
                }
                return quater; 
            }

            int getNumberFromUser(string message)
            {
                int result = 0;
                Console.WriteLine(message);
                result = Convert.ToInt32(Console.ReadLine());
                return result;
            }
            int quater = getNumberFromUser("Введите четверть: ");
            GetCoordinateFromQuater(quater); 



        }
    }
}

using System;

namespace Seminar3_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
           21. Напишите программу, которая принимает на вход координаты двух точек 
           и находит расстояние между ними в 2D пространстве.
           A (3,6); B (2,1) -> 5,09
           A (7,-5); B (1,-1) -> 7,21
           */ 

            int getNumberFromUser(string message)
            {
            int result = 0;
            Console.WriteLine(message);
            result = Convert.ToInt32(Console.ReadLine());
            return result;
            }

            double GetDistance (int xa, int ya, int xb, int yb)
            {
               double distance = Math.Sqrt(Math.Pow ((xb - xa),2)+ Math.Pow((yb-ya),2));
               return distance;
            }
            int xa = getNumberFromUser("Введите X1:");
            int ya = getNumberFromUser("Введите Y1:");
            int xb = getNumberFromUser("Введите X2:");
            int yb = getNumberFromUser("Введите Y2:");
            double distance = GetDistance( xa,  ya,  xb,  yb);
            Console.WriteLine($"Расстояние между точками равно {distance} ");
        }    

    }
}

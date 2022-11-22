using Internal;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.RegularExpressions;
using System;

namespace Seminar3_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
           Напишите программу, которая принимает на вход координаты двух точек 
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

            double GetDistance (int x1, int y1, int x2, int y2)
            {
               double distance = Match.Sqrt(Math.Pow (x2 - x1,2)+ Math.Pow(y2-y1,2));
            }
            int x1 = getNumberFromUser("Введите X1:");
            int y1 = getNumberFromUser("Введите Y1:");
            int x2 = getNumberFromUser("Введите X2:");
            int y2 = getNumberFromUser("Введите Y2:");
            int distance = GetDistance (int x1, int y1, int x2, int y2);
            Console.WriteLine($"Расстояние между точками равно {distance} ");
            

    }
}

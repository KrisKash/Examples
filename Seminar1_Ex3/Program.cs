using System;

namespace Seminar1_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = new int();
            Console.Write("Введите номер дня недели");
            userNumber = Convert.ToInt32(Console.ReadLine());
            if(userNumber == 1)
            {
                Console.WriteLine("Понедельник");
            }
            else if (userNumber == 2)
            {
                Console.WriteLine("Вторник");
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("Среда");
            }
            else if (userNumber == 4)
            {
                Console.WriteLine("Четверг");
            }
            else if (userNumber == 5)
            {
               Console.WriteLine("Пятница"); 
            }
            else if (userNumber == 6)
            {
               Console.WriteLine("Суббота");  
            }
            else if (userNumber == 7)
            {
                Console.WriteLine("Воскресенье"); 
            }
            else
            {
                Console.WriteLine("Такого дня недели не существует!");
            }
        }   
    }
}

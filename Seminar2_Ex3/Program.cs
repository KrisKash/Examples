using System;

namespace Seminar2_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Напишите программу, которая будет принимать на вход два числа и выводить, 
            является ли второе число кратным первому. 
            Если число 2 не кратно числу 1, то программа выводит остаток от деления.
            34, 5 -> не кратно, остаток 4, 
            16, 4 -> кратно
            */

            int userNumber1 = new int();
            Console.WriteLine("Введите число А: ");
            userNumber1 =Convert.ToInt32(Console.ReadLine());

            int userNumber2 = new int();
            Console.WriteLine("Введите число В: ");
            userNumber2 =Convert.ToInt32(Console.ReadLine());
            
            int result = 0;
        
            //int GetDelUserNumber (int userNumber1, int userNumber2)
            result = userNumber2 % userNumber1;
            
            

            if (result == 0) 
            {
                Console.WriteLine($"{userNumber2} кратно {userNumber1} ");
            }
            else
            {
                Console.WriteLine($"Остаток от деления равен {result} ");
            }
            

                
        }
    }
}

using System;

namespace Test_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объединение строк

            Console.WriteLine("Введите имя пользователя:");
            string username = Console.ReadLine();
            string s3 = "Hello, ";
            string s4 = s3 + username;
            Console.WriteLine(s4);
        }
    }
}

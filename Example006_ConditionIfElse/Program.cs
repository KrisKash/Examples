using System;

namespace Example006_ConditionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Поприветствовать пользователя - любимчика(ветвление)*/

            Console.WriteLine("Введите имя пользователя:");
            string username = Console.ReadLine();

            if(username.ToLower() == "маша")
            {
                Console.WriteLine("Ура, это же Маша!");
            }
            else
            {
                Console.Write("Привет,");
                Console.WriteLine(username);
            }
        }
    }
}

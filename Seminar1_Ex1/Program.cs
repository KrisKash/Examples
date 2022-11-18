using System;

namespace Example006_HelloMasha
{
    class Program
    {
        static void Main(string[] args)
        {
         int userNumber = new int();
         Console.WriteLine("Ведите число");
         userNumber = Convert.ToInt32(Console.ReadLine());
         int result = userNumber * userNumber;
         Console.WriteLine(result);
        }
    }
}

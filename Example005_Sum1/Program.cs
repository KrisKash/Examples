using System;

namespace Example005_Sum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = new Random().Next(1,10); // 1 2 3....9
            Console.WriteLine(numberA);
            int numberB = new Random().Next(1,10);
            Console.WriteLine(numberB);
            int result = numberA + numberB;
            Console.WriteLine(result);

        }
    }
}

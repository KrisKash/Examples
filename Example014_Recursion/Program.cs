using System;

namespace Example014_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            double Factorial (int n)
            {
               // 1! = 1
               // 0! = 1 
               if(n == 1 ) return 1;
               else return n * Factorial(n - 1);
            }
            for (int i = 1; i < 40; i++)
            {
                Console.WriteLine($"{i}! = {Factorial(i)}");
            }
            
            
        }
    }
}

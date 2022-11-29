using System;

namespace Example17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string NumbersFor (int a, int b)
            {
                string result = String.Empty;
                for (int i = a; a <= b; i++)
                {
                    result += $"{i} ";
                }
                return result;
            } */

            string NumbersRec (int a, int b)
            {
                if (a <= b) return $"{a} " + NumbersRec (a + 1, b);
                else
                {
                    return String.Empty;
                }
            }
            Console.WriteLine(NumbersRec(1,10));
        }
    }
}

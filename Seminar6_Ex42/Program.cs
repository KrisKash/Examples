using System;

namespace Seminar6_Ex44
{
    class Program
    {
        static void Main(string[] args)
        {
            int getNumberFromUser(string message) 
            { 
                int result = 0; 
                Console.WriteLine(message); 
                result = Convert.ToInt32(Console.ReadLine()); 
                return result; 
            } 
            
            string binaryNumber(int decimalNumber) 
            { 
                var binaryNumber = string.Empty; 
                while (decimalNumber > 0)  
                { 
                    binaryNumber = ((decimalNumber % 2) + binaryNumber); 
                    decimalNumber /= 2; 
                } 
                return binaryNumber; 
            } 
            
            int userNumber = getNumberFromUser("Введите число"); 
            var binNumber = binaryNumber(userNumber); 
            Console.WriteLine(binNumber);
        }
    }
}

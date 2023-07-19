using System;

namespace FizzBuzzWhiteBoardChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(15);
        }
        public static void FizzBuzz(int num)
        {
            if (num % 5 == 0 && num % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3 and 5.");  
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 3 or 5.");
            }
        } 
    }
}     




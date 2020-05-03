using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fizz = 3;
            int Buzz = 5;
            int FizzBuzz = Fizz * Buzz;
            int numberList = 100;

            for (int i = 1; i <= numberList; i++)
            {
                if (i % FizzBuzz == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % Fizz == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % Buzz == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            

        }
    }
}

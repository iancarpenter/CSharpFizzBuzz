using System;

namespace CSharpFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;

                if (fizz == true && buzz == true)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizz == true)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzz == true)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.Read();
        }
    }
}

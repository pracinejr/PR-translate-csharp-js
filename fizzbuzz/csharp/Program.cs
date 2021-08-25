using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            for (int i=1; i<= 100; i++) 
            {
                if (i % 15 == 0) 
            {
                Console.WriteLine("fizzbuzz");
            } else if (i % 3 == 0) 
            
            { 
                Console.WriteLine("fizz");
            } else if (i % 5 == 0) {
                Console.WriteLine("buzz");
            } else {
                Console.WriteLine(i);
            }
            }
        }
    }
}

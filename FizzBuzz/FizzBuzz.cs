using System;

namespace FizzBuzzNS
{
    public class FizzBuzz
    {
        public static void Main(string[] args)
        { 
            //
            // iterated through the list of numbers 1..100 and for numbers div by 3, fizz, and for numbers div by 5, buzz....
            //
            for (int i = 0; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine(" {0} is divisible by 3 AND 5!", i);
                }
                else
                {
                    if (i % 3 == 0) Console.WriteLine(" {0} is divisible by 3!", i);
                    if (i % 5 == 0) Console.WriteLine(" {0} is divisible by 5!", i);

                }
            }
        }
    
    }
}
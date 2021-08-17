using System;

namespace OddEven
{
   public class Program
    {
        public static bool IsPrime(int search)
        {
            int trigger = 0;
            int div = search / 2;
            for(int i = 2; i <= div; i++)
            {
                if (search % i == 0)
                {
                    //number is not prime
                    trigger = 1;
                    //break;
                    return false;
                }
            }
            if (trigger == 0)
            {
                //Console.WriteLine("PRIME NUMBER!");
                return true;
            }
            else return false;

        }
        
        public static void AdvancedFizzBuzz()
        {
            for(int i = 1; i <= 100; i++)
            {
                if (IsPrime(i) == true)
                {
                    Console.WriteLine("PRIME NUMBER" + i);
                }
                else if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz" + i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz" + i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz" + i);
                }
                
            }
        }
        static void Main(string[] args)
        {
            AdvancedFizzBuzz();
        }
    }
}

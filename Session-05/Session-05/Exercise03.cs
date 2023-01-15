using System;

namespace Exercise03
{
    internal class PrimeFinder
    {
        public void FindPrimes(int input)
        {
            Console.WriteLine("List of prime numbers from 1 to input n: ");
            for (int i=1; i<=input; i++)
            {
                if (isPrime(i))
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine();
        }

        private bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            int limit = Math.Ceiling(Math.Sqrt(number));

            for (int i = 2; i <= limit; ++i)
                if (number % i == 0)
                    return false;
            return true;

        }
    }
}
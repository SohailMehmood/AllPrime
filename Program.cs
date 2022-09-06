using System;

namespace AllPrime
{
    public static class AllPrime
    {
        public static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            const int MAX = int.MaxValue;

            for (int i = 1; i <= MAX; i++)
            {
                bool isPrime = IsPrime(i);
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        } 
        
        private static bool IsPrime(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

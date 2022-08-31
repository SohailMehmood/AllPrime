using System;

class AllPrime
{
    static bool isPrime(int number)
    {
        if (number == 0 || number == 1)
            return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main(String[] args)
    {
        int max = int.MaxValue;

        for (int i = 1; i <= max; i++)

            if (isPrime(i))
            {
                Console.WriteLine(i + " ");
            }
    }
}

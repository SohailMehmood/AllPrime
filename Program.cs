using System;

class AllPrime
{
    static bool isPrime(int n)
    {
        if (n == 0 || n == 1)
            return false;

        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void Main(String[] args)
    {
        int N = int.MaxValue;

        for (int i = 1; i <= N; i++)

            if (isPrime(i))
            {
                Console.WriteLine(i + " ");
            }
    }
}

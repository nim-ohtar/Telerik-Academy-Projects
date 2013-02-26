/*
 * Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm.
 */
using System;
using System.Text;

class Sieve
{
    public static long[] numbers;

    public static int field = 10000000;

    static void Main(string[] args)
    {
        StringBuilder resultString = new StringBuilder();

        numbers = new long[field];

        for (long i = 2; i < field; ++i)
        {
            numbers[i] = i;
        }


        for (long i = 2; i < field; ++i)
        {
            if (numbers[i] != 0)
            {
                resultString.Append(i).Append("   ");

                ClearNotPrime(i);
            }
        }

        Console.WriteLine(resultString.ToString());
    }

    private static void ClearNotPrime(long i)
    {
        for (long j = i * i; j < field; j+=i)
        {
            numbers[j] = 0;
        }
    }
}


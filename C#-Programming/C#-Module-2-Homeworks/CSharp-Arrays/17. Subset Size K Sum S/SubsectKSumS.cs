/*Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
 * Find in the array a subset of K elements that have sum S or indicate about its absence.
 * 
 * */
using System;

class SubsectKSumS
{
    static void Main(string[] args)
    {
        //Deifinition for the size of the input array
        int sizeN = 0;

        Console.WriteLine("Enter the size of the Input array:");

        //Entering the Size of the input array
        sizeN = int.Parse(Console.ReadLine());

        //Definition for the input Array
        int[] inputArray = new int[sizeN];

        Console.WriteLine("Enter the input array from the Console:");

        //Entering the input array from the console
        for (int i = 0; i < sizeN; ++i)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the target Sum:");

        //The target sum is entered from the Console
        int targetSum = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the size of the subset:");

        int targetSize = int.Parse(Console.ReadLine());

        if (targetSize < 1)
        {
            targetSize = 1;
        }

        if (targetSize > sizeN)
        {
            Console.WriteLine("Target Size larger than the input array's size");

            return;
        }

        //Storing the successful subset into an array
        int[] targetSubset = new int[targetSize];

        bool attemptSuccessful = false;

        attemptSuccessful = FindSubsetWithLengthK(inputArray, targetSize, 0, targetSum, targetSubset, 0);

        if (attemptSuccessful)
        {
            Console.WriteLine("Subset with Sum {0} found!", targetSum);

            for (int j = 0; j < targetSize; ++j)
            {
                Console.Write("{0} ", targetSubset[j]);
            }
        }
        else
        {
            Console.WriteLine("No such subset.");
        }

    }

    private static bool FindSubsetWithLengthK(int[] inputArray, int size, int start, int targetSum, int[] targetSubset, int lengthSubset)
    {
        if (size == 1)
        {
            for (int i = start; i < inputArray.Length; ++i)
            {
                if (targetSum - inputArray[i] == 0)
                {
                    targetSubset[lengthSubset] = inputArray[i];

                    return true;
                }
            }

            return false;
        }
        else
        {
            for (int i = start; i < inputArray.Length - 1; ++i)
            {
                if (FindSubsetWithLengthK(inputArray, size - 1, i + 1, targetSum - inputArray[i], targetSubset, lengthSubset + 1))
                {
                    targetSubset[lengthSubset] = inputArray[i];

                    return true;
                }
            }

            return false;
        }
    }
}


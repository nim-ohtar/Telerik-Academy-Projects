/*
 * We are given an array of integers and a number S. 
 * Write a program to find if there exists a subset of the elements of the array that has a sum S. 
 * Example:
 * arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
 * */
using System;

class SubsetExactSum
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
        
        //The target sum is enterd from the Console
        int targetSum = int.Parse(Console.ReadLine());

        //Storing the successful subset into an array
        int[] targetSubset = new int[sizeN];

        bool attemptSuccessful = false;

        //For each possible length try to find a subset with the target sum
        for (int i = 1; i <= sizeN; ++i)
        {
            attemptSuccessful = FindSubsetWithLengthK(inputArray, i, 0, targetSum, targetSubset, 0);

            if (attemptSuccessful)
            {
                Console.WriteLine("Subset with Sum {0} found!", targetSum);

                for (int j = 0; j < i; ++j)
                {
                    Console.Write("{0} ", targetSubset[j]);
                }

                return;
            }
        }

        Console.WriteLine("No such subset.");
    }

    private static bool FindSubsetWithLengthK(int[] inputArray, int size, int start, int targetSum, int[] targetSubset, int lengthSubset)
    {
        if (size == 1)
        {
            for(int i = start; i < inputArray.Length; ++i)
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


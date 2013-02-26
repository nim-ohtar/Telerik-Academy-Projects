/*
 * Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}
 * 
 * */
using System;

class MaxEqualSequence
{
    static void Main(string[] args)
    {
        int sizeN = 0;

        Console.WriteLine("Enter the size of the input array:");

        sizeN = int.Parse(Console.ReadLine());

        int[] inputArray = new int[sizeN];

        Console.WriteLine("Enter each element of the array on a separate line:");

        for (int i = 0; i < sizeN; ++i)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        int maxCount = 1;

        int tempCount = 1;

        int repeatNumber = inputArray[0];

        for (int i = 1; i < sizeN; ++i)
        {
            if (inputArray[i] == inputArray[i - 1])
            {
                ++tempCount;

                if (tempCount > maxCount)
                {
                    maxCount = tempCount;

                    repeatNumber = inputArray[i];
                }

            }
            else
            {
                tempCount = 1;
            }
        }

        Console.WriteLine("Most repeated number is {0} -> {1} times.",repeatNumber, maxCount);

    }
}


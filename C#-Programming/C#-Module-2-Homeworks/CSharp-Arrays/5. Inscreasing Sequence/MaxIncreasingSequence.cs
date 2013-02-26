/*
 * Write a program that finds the maximal increasing sequence in an array. 
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 * */

using System;

class MaxIncreasingSequence
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

        int endIndex = 0;

        for (int i = 1; i < sizeN; ++i)
        {
            if (inputArray[i] > inputArray[i - 1])
            {
                ++tempCount;

                if (tempCount > maxCount)
                {
                    maxCount = tempCount;

                    endIndex = i;
                }

            }
            else
            {
                tempCount = 1;
            }
        }

        Console.WriteLine("The longest Increasing sequence in the input array is :");

        for (int i = endIndex - maxCount + 1; i <= endIndex; ++i)
        {
            Console.Write("{0,3}",inputArray[i]);
        }
        Console.WriteLine(" with length {0}", maxCount);

    }
}


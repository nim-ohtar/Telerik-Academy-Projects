/*
 * Write a program that finds the sequence of maximal sum in given array. Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
 * 
 * */
using System;
using System.Text;

class MaxSumSequence
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

        //Current left index
        int leftIndex = 0;

        //Current Right Index
        int rightIndex = 0;

        //Current Sum
        int currentSum = inputArray[0];

        //Best sequence left index
        int maxLeftIndex = 0;

        //Best Sequence Right index
        int maxRightIndex = 0;

        //Best sequence Sum
        int maxSum = inputArray[0];

        //Traverse teh array only once, moving the left and right indexes
        for (int i = 1; i < sizeN; ++i)
        {
            rightIndex = i;

            if (currentSum < 0)
            {
                leftIndex = i;

                currentSum = inputArray[i];
            }
            else
            {
                currentSum += inputArray[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;

                maxLeftIndex = leftIndex;

                maxRightIndex = rightIndex;
            }
        }

        //Print the result sequence
        Console.WriteLine("Maximum sequence is :");

        StringBuilder resultString = new StringBuilder();

        for (int i = maxLeftIndex; i <= maxRightIndex; ++i)
        {
            resultString.Append(inputArray[i]).Append(" ");
        }

        Console.WriteLine(resultString.ToString()+"\nTotal sum: {0}",maxSum);

    }
}


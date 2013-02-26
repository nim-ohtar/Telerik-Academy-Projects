/*
    Write a program that reads an array of integers and removes from it a minimal number of elements
    in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
    {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
*/
using System;

class MaxMonSubSet
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

        //Finding the maximum length, non consecutive, growing sequence
        int[] helpArray = new int[sizeN];

        int maxLength = 1;

        for (int i = 0; i < sizeN; ++i)
        {
            helpArray[i] = 1;

            for (int j = 0; j < i; ++j)
            {
                if (inputArray[i] >= inputArray[j] && helpArray[i] <= helpArray[j])
                {
                    helpArray[i] = helpArray[j] + 1;
                }
            }

            if (maxLength < helpArray[i])
            {
                maxLength = helpArray[i];
            }
        }

        int[] resultArray = new int[maxLength];

        int count = sizeN - 1;
        while (maxLength != 0)
        {
            if (helpArray[count] == maxLength)
            {
                resultArray[maxLength-1] = inputArray[count];

                --maxLength;
            }

            --count;
        }


        //Printing the result array
        Console.WriteLine("The maximum length growing sequence is:");

        foreach (int item in resultArray)
        {
            Console.Write("{0,-3}",item);
        }
    }
}


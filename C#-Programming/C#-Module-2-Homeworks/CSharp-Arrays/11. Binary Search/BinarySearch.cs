/*
 * Write a program that finds the index of given element in a sorted array of integers
 * by using the binary search algorithm.
 * */
using System;

class BinarySearch
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

        Console.WriteLine("Enter the desired number:");

        int searchNumber = int.Parse(Console.ReadLine());

        if (searchNumber < inputArray[0] || searchNumber > inputArray[sizeN - 1])
        {
            Console.WriteLine("Number not found.");
        }

        //The desired number index
        int resultIndex = -1;

        int currentIndex = 0;

        int leftBorder = 0;

        int rightBorder = sizeN - 1;

        //Binary Search alrogithm
        while (leftBorder < rightBorder)
        {
            currentIndex = (leftBorder + rightBorder) / 2;

            if (inputArray[currentIndex] == searchNumber)
            {
                resultIndex = currentIndex;

                break;
            }

            if (inputArray[currentIndex] < searchNumber)
            {
                leftBorder = currentIndex + 1;
            }
            else
            {
                rightBorder = currentIndex - 1;
            }

        }

        //Printing the resultot the Console
        if (resultIndex == -1)
        {
            Console.WriteLine("Number not found.");
        }
        else
        {
            Console.WriteLine("Number found! Index: {0}", resultIndex);
        }

    }
}

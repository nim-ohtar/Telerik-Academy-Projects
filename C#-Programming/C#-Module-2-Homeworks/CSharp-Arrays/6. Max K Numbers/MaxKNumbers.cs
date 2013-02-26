/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum
 * */
using System;

class MaxKNumbers
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

        int sizeK = 0;

        Console.WriteLine("Enter the number K:");

        sizeK = int.Parse(Console.ReadLine());

        if (sizeK > sizeN)
        {
            sizeK = sizeN;
        }

        //Sorting the input array
        //Selection Sort
        int minElemIndex = 0;

        int temp = 0;

        for (int i = 0; i < sizeN - 1; ++i)
        {

            for (int j = i; j < sizeN; ++j)
            {
                if (inputArray[j] < inputArray[minElemIndex])
                {
                    minElemIndex = j;
                }
            }

            temp = inputArray[i];

            inputArray[i] = inputArray[minElemIndex];

            inputArray[minElemIndex] = temp;

            minElemIndex = i + 1;

        }

        Console.WriteLine("The {0} greatest elements are :", sizeK);
        
        int totalSum = 0;

        //Printing to the console the biggest K numbers and adding them to a sum
        for (int i = 0; i < sizeK; ++i)
        {
            Console.Write("{0,-3}", inputArray[sizeN - sizeK + i]);
            
            totalSum += inputArray[sizeN - sizeK + i];
        }

        //Printing the sum in the end
        Console.WriteLine("Total sum: {0}", totalSum);

    }
}


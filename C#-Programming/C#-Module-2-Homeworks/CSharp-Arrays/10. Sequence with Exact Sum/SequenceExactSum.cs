//Program for pritning the sequence in an array that has exact sum as enterd from the console
using System;

class SequenceExactSum
{
    static void Main(string[] args)
    {
        //Deifinition for the size of the input array
        int sizeN = 0;

        Console.WriteLine("Enter the size of the Input array:");

        //Entering the Size of the input array
        sizeN = int.Parse(Console.ReadLine());

        //Definition for the input Array
        int[] arr = new int[sizeN];

        Console.WriteLine("Enter the input array from the Console:");

        //Entering the input array from the console
        for (int i = 0; i < sizeN; ++i)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        //THe exact sum desired
        int exactSum = 0;

        Console.WriteLine("Enter the exact sum:");

        //ENter the exact sum from the Console
        exactSum = int.Parse(Console.ReadLine());

        //Variables used for the algorithm
        int startIndex = 0;

        int endIndex = 0;

        bool isSequnceAvailable = false;

        int tempSum = arr[0];

        //GO over all sequences until the sequence with the desired sum is found or run out of new sequences
        for (int i = 0; i < sizeN; ++i)
        {
            if (arr[i] == exactSum)
            {
                isSequnceAvailable = true;

                startIndex = i;

                endIndex = i;

                break;
            }

            tempSum = arr[i];

            for (int j = i + 1; j < sizeN; ++j)
            {
                tempSum += arr[j];

                if (tempSum == exactSum)
                {
                    isSequnceAvailable = true;

                    startIndex = i;

                    endIndex = j;

                    break;
                }
            }
        }

        //Printing the result
        if (isSequnceAvailable)
        {
            Console.Write("The sequence with sum {0} is [ ",exactSum);
            for (int i = startIndex; i <= endIndex; ++i)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("]");
        }
        else
        {
            Console.WriteLine("No such sequence.");
        }
    }
}


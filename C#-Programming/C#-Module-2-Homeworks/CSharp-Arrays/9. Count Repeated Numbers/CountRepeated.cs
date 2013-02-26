using System;

class CountRepeated
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

        //Sorting the Array First
        //Selection Sort
        int minElemIndex = 0;

        int temp = 0;

        for (int i = 0; i < sizeN - 1; ++i)
        {

            for (int j = i; j < sizeN; ++j)
            {
                if (arr[j] < arr[minElemIndex])
                {
                    minElemIndex = j;
                }
            }

            temp = arr[i];

            arr[i] = arr[minElemIndex];

            arr[minElemIndex] = temp;

            minElemIndex = i + 1;

        }

        //Variable holdind the most repeated number
        int repeatedNumber = arr[0];
        
        //Counter for the repetiotions of the most repeated number
        int maxRepeatedCount = 1;

        //temp variable storing the current repeated number count
        int tempCount = 1;

        //Go through the sorted Array and count the repeated numbers, get the most repeated
        for (int i = 1; i < sizeN; ++i)
        {
            if (arr[i - 1] == arr[i])
            {
                ++tempCount;

                if (maxRepeatedCount < tempCount)
                {
                    maxRepeatedCount = tempCount;

                    repeatedNumber = arr[i];
                }
            }
            else
            {
                tempCount = 1;
            }

        }

        //Print the result
        Console.WriteLine("The most repeated number is {0} -> {1}", repeatedNumber, maxRepeatedCount);
    }
}


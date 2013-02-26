//Merge Sort
using System;

class MergeSort
{
    static void Main(string[] args)
    {
        int sizeN = 0;

        Console.WriteLine("Enter the size of the input array:");

        sizeN = int.Parse(Console.ReadLine());

        int[] inputArray = new int[sizeN];

        int[] resultArray = new int[sizeN];

        Console.WriteLine("Enter the input array numbers, each on a separate line:");

        for (int i = 0; i < sizeN; ++i)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        //Merge Sort
        MergeSortArray(inputArray, resultArray);

        for (int i = 0; i < sizeN; ++i)
        {
            Console.WriteLine(resultArray[i]); 
        }

    }

    private static void MergeSortArray(int[] inputArray, int[] resultArray)
    {
        MergeSortHelp(inputArray, 0, inputArray.Length - 1, resultArray);
    }

    private static void MergeSortHelp(int[] inputArray, int p1, int p2, int[] resultArray)
    {
        if (p1 == p2)
        {
            return;
        }

        int middle = (p1 + p2) / 2;


        MergeSortHelp(inputArray, p1, middle, resultArray);

        MergeSortHelp(inputArray, middle + 1, p2, resultArray);

        MergeSequences(inputArray, p1, middle, middle + 1, p2, resultArray);
    }

    private static void MergeSequences(int[] inputArray, int a1, int a2, int b1, int b2, int[] resultArray)
    {
        int i = a1;
        int j = b1;

        int index=a1;

        int length1 = a2;
        int length2 = b2;

        while (i <= length1 && j <= length2)
        {
            if (inputArray[i] <= inputArray[j])
            {
                resultArray[index] = inputArray[i];
                
                ++i;

                ++index;
            }
            else
            {
                resultArray[index] = inputArray[j];
                
                ++j;

                ++index;
            }
        }

        while (j <= length2)
        {
            resultArray[index] = inputArray[j];

            ++j;

            ++index;
        }

        while (i <= length1)
        {
            resultArray[index] = inputArray[i];
            
            ++i;

            ++index;
        }

        for (int p = a1; p <= b2; ++p)
        {
            inputArray[p] = resultArray[p];

        }

    }


}


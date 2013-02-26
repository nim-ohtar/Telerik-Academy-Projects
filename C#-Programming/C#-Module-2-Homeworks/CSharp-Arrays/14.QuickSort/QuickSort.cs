//QuickSort
using System;

class QuickSort
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

        //QuickSort
        QuickSortArray(inputArray, 0, inputArray.Length - 1);

        //Printing the Sorted Array
        for (int i = 0; i < sizeN; ++i)
        {
            Console.Write("{0,-4}", inputArray[i]);
        }
    }

    public static void QuickSortArray(int[] inputArray, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        int pivot = QSortHelp(inputArray, start, end);

        QuickSortArray(inputArray, start, pivot - 1);

        QuickSortArray(inputArray, pivot + 1, end);
    }

    public static int QSortHelp(int[] inputArray, int left, int right)
    {

        int pivotIndex = right;

        int leftIndex = left;

        int rightIndex = right;

        while (leftIndex < rightIndex)
        {
            while (inputArray[leftIndex] < inputArray[pivotIndex]) 
            {
                ++leftIndex;
            }

            while (rightIndex >= left && inputArray[rightIndex] >= inputArray[pivotIndex]) 
            {
                --rightIndex;
            }

            if (leftIndex < rightIndex)
            {
                Swap(inputArray, leftIndex, rightIndex);

                ++leftIndex;
            }
        }

        //Tricky Part here (Imagine an array with 2 elements)
        if (leftIndex != pivotIndex)
        {
            Swap(inputArray, leftIndex, pivotIndex);
        }

        return leftIndex;
    }

    private static void Swap(int[] inputArray, int leftIndex, int rightIndex)
    {
        int tempNumber = inputArray[leftIndex];

        inputArray[leftIndex] = inputArray[rightIndex];

        inputArray[rightIndex] = tempNumber;
    }
}

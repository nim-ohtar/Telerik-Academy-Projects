//Program using Selection sort to sort an array, entered from the console
using System;

class SelectionSort
{
    static void Main(string[] args)
    {
        int sizeN = 0;

        Console.WriteLine("Enter the size of the input array:");

        sizeN = int.Parse(Console.ReadLine());

        int[] arr = new int[sizeN];

        Console.WriteLine("Enter each element of the array on a separate line:");

        for (int i = 0; i < sizeN; ++i)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

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

        Console.WriteLine("The Sorted Array is:");

        //Print the sorted array
        for(int i=0;i<sizeN;++i)
        {
            Console.WriteLine(arr[i]);
        }

    }
}


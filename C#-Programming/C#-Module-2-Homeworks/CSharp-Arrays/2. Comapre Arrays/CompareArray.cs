//Write a program that reads two arrays from the console and compares them element by element.
using System;

class CompareArray
{
    static void Main(string[] args)
    {
        int sizeA;
        int sizeB;

        Console.WriteLine("Enter the sizes of both arrays on separate lines:");

        sizeA = int.Parse(Console.ReadLine());

        sizeB = int.Parse(Console.ReadLine());

        if (sizeA != sizeB)
        {
            Console.WriteLine("Not the same.");
            return;
        }

        int[] arrA = new int[sizeA];

        int[] arrB = new int[sizeA];

        Console.WriteLine("Enter the first array, each element on separate line:");

        for (int i = 0; i < sizeA; ++i)
        {
            arrA[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the second array, each element on separate line:");

        for (int i = 0; i < sizeA; ++i)
        {
            arrB[i] = int.Parse(Console.ReadLine());
        }

        //Compare the arrays
        for (int i = 0; i < sizeA; ++i)
        {
            if (arrA[i] != arrB[i])
            {
                Console.WriteLine("Not the same.");
                
                return;
            }
        }

        Console.WriteLine("Same arrays.");

    }
}


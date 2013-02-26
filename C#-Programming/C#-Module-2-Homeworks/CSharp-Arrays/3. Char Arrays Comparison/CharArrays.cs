/*
 * Write a program that compares two char arrays lexicographically (letter by letter).
 * */

using System;

class CharArrays
{
    static void Main(string[] args)
    {
        //Size for the first array
        int sizeN = 0;

        Console.WriteLine("Enter the size of the first array:");

        sizeN = int.Parse(Console.ReadLine());

        //Creating the first array
        char[] firstArray = new char[sizeN];

        Console.WriteLine("Enter the elements of the first array on separate lines:");

        char tempChar = ' ';

        //Entering the values for the first array fromthe Console
        for (int i = 0; i < sizeN; ++i)
        {
            tempChar = char.Parse(Console.ReadLine());

            //If the letter is big, make it small
            if (tempChar <= 90 && tempChar >= 65)
            {
                tempChar = (char)(tempChar + 32);
            }

            firstArray[i] = tempChar;
        }

        //Definition for the size of the second array
        int sizeK = 0;

        Console.WriteLine("Enter the size of the second array:");

        sizeK = int.Parse(Console.ReadLine());

        //Definition for the second array
        char[] secondArray = new char[sizeK];

        Console.WriteLine("Enter the elements of the second array on separate lines:");

        //Entering the values of the second array from the console
        for (int i = 0; i < sizeK; ++i)
        {
            tempChar = char.Parse(Console.ReadLine());

            //If the letter is big, make it small
            if (tempChar <= 90 && tempChar >= 65)
            {
                tempChar = (char)(tempChar + 32);
            }

            secondArray[i] = tempChar;
        }

        //Comparing the arrays letter by letter until a difference occur or one of the arrrays is over
        for (int i = 0; i < sizeK && i < sizeN; ++i)
        {
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("First Array is before the Second.");

                return;
            }

            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("Second Array is before the First.");

                return;
            }
        }

        if (sizeN > sizeK)
        {
            Console.WriteLine("Second Array is before the First.");
        }
        else if (sizeN < sizeK)
        {
            Console.WriteLine("First Array is before the Second.");
        }
        else
        {
            Console.WriteLine("Equal arrays.");
        }


    }
}

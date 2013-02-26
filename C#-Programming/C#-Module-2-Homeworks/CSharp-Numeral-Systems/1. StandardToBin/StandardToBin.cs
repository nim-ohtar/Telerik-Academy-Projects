/*
 * Write a program to convert decimal numbers to their binary representation.

 */
using System;
using System.Collections.Generic;
using System.Text;

class StandardToBin
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a standard number to convert to Binary:");

        int inputNumber = int.Parse(Console.ReadLine());

        string result = ConvertStandardToAnyNumSys(inputNumber, 2);

        Console.WriteLine("{0} in Binary is {1}.", inputNumber, result);
    }

    //Convert from 10 based to any other numeral system
    private static string ConvertStandardToAnyNumSys(int numberCnverted, int outputNumSys)
    {
        if (outputNumSys == 10)
        {
            return numberCnverted.ToString();
        }

        StringBuilder resultNumber = new StringBuilder();

        List<char> charList = new List<char>();

        int tempNum = 0;

        char tempChar = ' ';

        bool negativeNumber = false;

        //Check for negative numbers
        if (numberCnverted < 0)
        {
            negativeNumber = true;

            numberCnverted = -numberCnverted;
        }

        while (numberCnverted > 0)
        {
            tempNum = numberCnverted % outputNumSys;

            if (tempNum > 9)
            {
                //If the number is greater than 9, use letters
                tempChar = (char)(tempNum + 55);
            }
            else
            {
                tempChar = (char)(tempNum + 48);
            }

            charList.Add(tempChar);

            numberCnverted /= outputNumSys;

        }

        if (negativeNumber)
        {
            resultNumber.Append('-');
        }

        //Add the characters of the number in reverse order to the result string
        for (int i = charList.Count - 1; i >= 0; --i)
        {
            resultNumber.Append(charList[i]);
        }

        return resultNumber.ToString();
    }
}


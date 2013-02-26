/*
 * Write a program to convert hexadecimal numbers to binary numbers (directly)
 */
using System;
using System.Collections.Generic;
using System.Text;

class HextToBinary
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to convert from Hex to Binary:");

        string inputNumber = Console.ReadLine();

        char sign = inputNumber[0];

        if (sign == '-' || sign == '+')
        {
            inputNumber = inputNumber.Substring(1);
        }

        string result = ConvertHexToBin(inputNumber);

        if (sign == '-')
        {
            Console.WriteLine("{0} in Binary is {2}{1}.", inputNumber, result, sign);
        }
        else
        {
            Console.WriteLine("{0} in Binary is {1}.", inputNumber, result);
        }
    }

    //Recursive method for converting Hex to Binary
    private static string ConvertHexToBin(string inputNumber)
    {
        if (inputNumber.Length == 1)
        {
            return ConvertHexLetterToBinary(inputNumber[0]);
        }

        StringBuilder resultString = new StringBuilder();

        resultString.Append(ConvertHexToBin(inputNumber.Substring(1, inputNumber.Length - 1)));

        resultString.Append(ConvertHexLetterToBinary(inputNumber[0]));

        return resultString.ToString();
    }

    private static string ConvertHexLetterToBinary(char inputLetter)
    {
        int inputNumber = 0;

        if (inputLetter <= '9' )
        {
            inputNumber = inputLetter - '0';
        }
        else if (inputLetter < 'Z')
        {
            inputNumber = 10 + inputLetter - 'A';
        }
        else
        {
            inputNumber = 10 + inputLetter - 'a';
        }

        return CovertToAnyNumSys(inputNumber, 2);
    }

    //Convert from 10 based to any other numeral system
    private static string CovertToAnyNumSys(int numberCnverted, int outputNumSys)
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

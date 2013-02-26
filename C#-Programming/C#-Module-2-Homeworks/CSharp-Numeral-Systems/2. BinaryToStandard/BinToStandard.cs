/*
 * Write a program to convert binary numbers to their decimal representation.

 * */
using System;

class BinToStandard
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a binary number to convert to Standard Numberal Suystem (10-based):");

        string inputNumber = Console.ReadLine();

        int result = ConvertToStandardNumSys(inputNumber, 2);

        Console.WriteLine("{0} in Standard Numberal System (10-based) is {1}.", inputNumber, result);
    }

        //Convert from any numeral system to 10 based numeral system
    private static int ConvertToStandardNumSys(string number, int inputNumSys)
    {
        if (inputNumSys == 10)
        {
            return int.Parse(number);
        }

        char[] inputNumberChars;

        //cehck for signs in the Number
        char sign = '+';

        if (number.StartsWith("-"))
        {
            sign = '-';
        }

        //In case the number is in the format "0x124", forget about the first 2 character
        int indexOfHexSymbols = number.IndexOf("0x", StringComparison.InvariantCultureIgnoreCase);

        if (indexOfHexSymbols != -1)
        {
            inputNumberChars = number.Substring(indexOfHexSymbols + 2).ToCharArray();
        }
        else
        {
            inputNumberChars = number.ToCharArray();
        }

        int multiplier = 1;

        char tempChar = '0';

        int tempNum = 0;

        int resultNumber = 0;

        //Convert each symbol to a nubmer and add it to the result
        for (int i = inputNumberChars.Length - 1; i >= 0; --i)
        {
            tempChar = inputNumberChars[i];

            if (tempChar > 47 && tempChar < 58)
            {
                tempNum = tempChar - '0';
            }
            else if (tempChar >= 'A' && tempChar <= 'F')
            {
                tempNum = 10 + tempChar - 'A';
            }
            else if (tempChar >= 'a' && tempChar <= 'f')
            {
                tempNum = 10 + tempChar - 'a';
            }
            else if (tempChar == '-' || tempChar == '+')
            {
                sign = tempChar;

                continue;
            }

            resultNumber += tempNum * multiplier;

            multiplier *= inputNumSys;
        }

        if (sign == '-')
        {
            resultNumber = -resultNumber;
        }

        return resultNumber;
    }
}


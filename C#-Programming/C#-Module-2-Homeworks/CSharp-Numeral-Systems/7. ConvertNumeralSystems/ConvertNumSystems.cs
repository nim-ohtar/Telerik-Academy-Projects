/*
 * Write a program to convert from any numeral system of given base s 
 * to any other numeral system of base d (2 ≤ s, d ≤  16)
 * */

using System;
using System.Collections.Generic;
using System.Text;


class ConvertNumSystems
{
    static void Main(string[] args)
    {
        //Variables for storing the input from the console
        int inputNumSys = 10;

        int outputNumSys = 10;

        string inputNumber = "";

        //Prompt for the input Number System
        Console.WriteLine("Please enter Input Numeral System(2 to 16):");

        inputNumSys = int.Parse(Console.ReadLine());

        if (inputNumSys < 2 || inputNumSys > 16 )
        {
            Console.WriteLine("Wrong input.");

            return;
        }

        //Prompt for the Output Number System
        Console.WriteLine("Enter an Output Numeral System(2 to 16):");

        outputNumSys = int.Parse(Console.ReadLine());

        if (outputNumSys < 2 || outputNumSys > 16)
        {
            Console.WriteLine("Wrong input.");

            return;
        }

        Console.WriteLine("Enter a number in the Input Numeral System ({0})", inputNumSys);

        inputNumber = Console.ReadLine();

        bool correctInput = ValidateInputNumber(inputNumber, inputNumSys);

        if (!correctInput)
        {
            Console.WriteLine("Invalid number entered.");

            return;
        }


        //Convert the number
        string result = ConvertNumber(inputNumber, inputNumSys, outputNumSys);

        //Print the result
        Console.WriteLine("The number {0} in {1} is {2} in {3} numeral system.", inputNumber, inputNumSys, result, outputNumSys);

    }

    //Validating the input using Regular Expression
    private static bool ValidateInputNumber(string inputNumber, int inputNumSys)
    {
        //Determining teh maximum Digit allowed
        int maxDigit = inputNumSys >= 9 ? 9 : inputNumSys - 1;

        //Determining if letters are going to be used
        string lettersAllowed = inputNumSys < 11 ? "" : "a-" + (char)('f' - (16 - inputNumSys));

        //Allow Hex Style Syntax for Hex Numbers
        string hexLikeSyntax = inputNumSys == 16 ? "(0x)?" : "";

        //COnstruct the Regular Expression
        string sPattern = "^[+-]?" + hexLikeSyntax + "[0-" + maxDigit + lettersAllowed + "]+\\Z";

        //Check for correct format
        bool result = System.Text.RegularExpressions.Regex.IsMatch(inputNumber, sPattern,
            System.Text.RegularExpressions.RegexOptions.IgnoreCase);

        return result;
    }

    //Convert from any to any numeral system
    public static string ConvertNumber(string number, int inputNumSys, int outputNumSys)
    {
        //If the numeral systems are the same no need to convert
        if (inputNumSys == outputNumSys)
        {
            return number;
        }

        //Convert to 10 based numeral system
        int numberCnverted = ConvertToStandardNumSys(number, inputNumSys);

        //Convet from 10 based to the output Numeral System
        string numberToOutputNumSys = ConvertStandardToAnyNumSys(numberCnverted, outputNumSys);

        //return the result
        return numberToOutputNumSys;

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

    //Convert from 10 based to any other numeral system
    private static string ConvertStandardToAnyNumSys(int numberCnverted, int outputNumSys)
    {
        if (outputNumSys == 10 || numberCnverted == 0)
        {
            return numberCnverted.ToString();
        }

        StringBuilder resultNumber = new StringBuilder();

        List<char> charList = new List<char>();

        int tempNum= 0;

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


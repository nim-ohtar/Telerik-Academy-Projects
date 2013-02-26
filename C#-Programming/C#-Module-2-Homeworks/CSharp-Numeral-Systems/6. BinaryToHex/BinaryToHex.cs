/*
 * Write a program to convert binary numbers to hexadecimal numbers (directly).
 * 
 * */
using System;
using System.Text;

class BinaryToHex
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number to convert from binary to Hex:");

        string inputNumber = Console.ReadLine();

        char sign = inputNumber[0];

        if (sign == '-' || sign == '+')
        {
            inputNumber = inputNumber.Substring(1);
        }

        string result = ConvertBinToHex(inputNumber);

        if (sign == '-')
        {
            Console.WriteLine("{0} in Hex is {2}{1}.", inputNumber, result, sign);
        }
        else
        {
            Console.WriteLine("{0} in Hex is {1}.", inputNumber, result);
        }
    }

    private static string ConvertBinToHex(string inputNumber)
    {
        if (inputNumber.Length <= 4)
        {
            return ConvertHalfByteToHex(inputNumber);
        }

        StringBuilder resultString = new StringBuilder();

        resultString.Append(ConvertBinToHex(inputNumber.Substring(4,inputNumber.Length-4)));

        resultString.Append(ConvertHalfByteToHex(inputNumber.Substring(0, 4)));

        return resultString.ToString();
    }

    private static string ConvertHalfByteToHex(string inputNumber)
    {
        char[] chars = inputNumber.ToCharArray();

        int multiplier = 1;

        int resultNubmer = 0;

        for (int i = chars.Length - 1; i >= 0 ; i--)
		{
            resultNubmer += (chars[i] - '0')*multiplier;

            multiplier *= 2;
		}

        if (resultNubmer < 10)
        {
            return resultNubmer.ToString();
        }
        else
        {
            return (char)('A' + resultNubmer - 10) + "";
        }
    }
}



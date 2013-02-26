/*
 * 
 * Write a program that shows the internal binary representation of given 32-bit signed floating-point number
 * in IEEE 754 format (the C# type float). 
 * */
using System;
using System.Linq;
using System.Text;

class FloatToBinary
{
    public static void Main()
    {
        //Enter a floating point from the console
        Console.WriteLine("Please, enter a float number: ");

        float inputNumber = Single.Parse(Console.ReadLine());

        //Converting the input number to Hexademical Numeral System
        string hexNumber = ConvertFloatToHex(inputNumber);

        StringBuilder binaryResult = new StringBuilder();

        //Convert the hexademical number to binary, using switch case
        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case '0':
                    binaryResult.Append("0000");
                    break;
                case '1':
                    binaryResult.Append("0001");
                    break;
                case '2':
                    binaryResult.Append("0010");
                    break;
                case '3':
                    binaryResult.Append("0011");
                    break;
                case '4':
                    binaryResult.Append("0100");
                    break;
                case '5':
                    binaryResult.Append("0101");
                    break;
                case '6':
                    binaryResult.Append("0110");
                    break;
                case '7':
                    binaryResult.Append("0111");
                    break;
                case '8':
                    binaryResult.Append("1000");
                    break;
                case '9':
                    binaryResult.Append("1001");
                    break;
                case 'A':
                    binaryResult.Append("1010");
                    break;
                case 'a':
                    binaryResult.Append("1010");
                    break;
                case 'B':
                    binaryResult.Append("1011");
                    break;
                case 'b':
                    binaryResult.Append("1011");
                    break;
                case 'C':
                    binaryResult.Append("1100");
                    break;
                case 'c':
                    binaryResult.Append("1100");
                    break;
                case 'D':
                    binaryResult.Append("1101");
                    break;
                case 'd':
                    binaryResult.Append("1101");
                    break;
                case 'E':
                    binaryResult.Append("1110");
                    break;
                case 'e':
                    binaryResult.Append("1110");
                    break;
                case 'F':
                    binaryResult.Append("1111");
                    break;
                case 'f':
                    binaryResult.Append("1111");
                    break;
            }
        }

        //Print The result
        Console.WriteLine("The number {0} converted to binary will look like this:\n{1}", inputNumber, binaryResult);
    }

    public static string ConvertFloatToHex(float argument)
    {
        byte[] byteArray = BitConverter.GetBytes(argument);

        Array.Reverse(byteArray);

        string result = BitConverter.ToString(byteArray);

        return result;
    }
}
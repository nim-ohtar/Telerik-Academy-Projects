/*
 * Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short)
 * */
using System;

class ShortIntToBin
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a signed short(16-bit) integer Number:");

        short shortNumber = short.Parse(Console.ReadLine());

        Console.Write("The number {0} is ", shortNumber);

        int mask = 1;

        for (int i = 15; i >= 0; i--)
        {
            mask = 1 << i;

            if ((shortNumber & mask) == 0)
            {
                Console.Write(0);
            }
            else
            {
                Console.Write(1);
            }
        }

        Console.WriteLine(" in binary.");

        float p = 12.5f;

    }
}


//Variations with length K of numbers [1...N] 
using System;
using System.Text;

class Variations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N:");

        int sizeN = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter K:");

        int sizeK = int.Parse(Console.ReadLine());

        int[] variation = new int[sizeK];

        StringBuilder resultVariations = new StringBuilder();

        RecVariation(sizeN, sizeK, variation, resultVariations);

        Console.WriteLine(resultVariations.ToString());

    }

    private static void RecVariation(int sizeN, int sizeK, int[] variation, StringBuilder resultVariations)
    {
        if (sizeK == 1)
        {
            for (int i = 1; i <= sizeN; ++i)
            {
                variation[0] = i;

                PrintVariation(variation, resultVariations);
            }
        }
        else
        {
            for (int i = 1; i <= sizeN; ++i)
            {
                variation[sizeK - 1] = i;

                RecVariation(sizeN, sizeK - 1, variation, resultVariations);
            }
        }


    }

    private static void PrintVariation(int[] variation, StringBuilder resultVariations)
    {
        StringBuilder variationString = new StringBuilder();

        variationString.Append("{ ");

        for (int i = 0; i < variation.Length; ++i)
        {
            variationString.Append(variation[i]).Append(",");
        }

        variationString.Remove(variationString.Length-1,1);

        variationString.Append(" }");

        resultVariations.Append("\n").Append(variationString.ToString());
    }

}


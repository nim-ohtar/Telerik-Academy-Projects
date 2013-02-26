/*
 * Write a program that reads two numbers N and K and generates all the combinations of K distinct elements
 * from the set [1..N]. Example:
 * N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
 * 
 */
using System;
using System.Text;

class Combinations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N:");

        int sizeN = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter K:");

        int sizeK = int.Parse(Console.ReadLine());

        int[] combination = new int[sizeK];

        StringBuilder resultCombination = new StringBuilder();

        RecCombination(sizeN, 0, combination, resultCombination);

        Console.WriteLine(resultCombination.ToString());

    }

    private static void RecCombination(int sizeN, int index, int[] combination, StringBuilder resultCombination)
    {
        if (index == combination.Length - 1)
        {
            for (int i = combination.Length; i <= sizeN; ++i)
            {
                combination[index] = i;

                PrintCombination(combination, resultCombination);
            }
        }
        else
        {
            for (int i = index + 1; i <= sizeN; ++i)
            {
                combination[index] = i;

                RecCombination(sizeN, index + 1, combination, resultCombination);
            }
        }


    }

    private static void PrintCombination(int[] combination, StringBuilder resultCombination)
    {
        StringBuilder combinationString = new StringBuilder();

        combinationString.Append("{ ");

        for (int i = 0; i < combination.Length; ++i)
        {
            combinationString.Append(combination[i]).Append(",");
        }

        combinationString.Remove(combinationString.Length - 1, 1);

        combinationString.Append(" }");

        resultCombination.Append("\n").Append(combinationString.ToString());
    }
}

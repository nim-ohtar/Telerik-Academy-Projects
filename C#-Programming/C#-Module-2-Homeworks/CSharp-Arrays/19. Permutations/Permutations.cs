/*
 * Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. Example:
 *	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
 */ 
using System;
using System.Text;

class Permutations
{
    public static int[] numbers;

    static void Main(string[] args)
    {
        //Enter the size N from the Console
        Console.WriteLine("Please enter the size N:");

        int sizeN = int.Parse(Console.ReadLine());

        int[] permutation = new int[sizeN];

        numbers = new int[sizeN];

        for (int i = 0; i < sizeN; ++i)
        {
            numbers[i] = i + 1;
        }

        GeneratePermuation(permutation, 0);

    }

    public static void GeneratePermuation(int[] permutation, int index)
    {
        int temp = 0;

        if (index == permutation.Length - 1)
        {
            permutation[index] = numbers[index];

            PrintPermutation(permutation);
        }
        else
        {
            permutation[index] = numbers[index];

            GeneratePermuation(permutation, index + 1);

            for (int i = 1; i < permutation.Length - index; ++i)
            {
                temp = numbers[index + i];

                numbers[index + i] = permutation[index];

                permutation[index] = temp;

                GeneratePermuation(permutation, index + 1);

                temp = numbers[index + i];

                numbers[index + i] = permutation[index];

                permutation[index] = temp;
            }
        }
    }

    private static void PrintPermutation(int[] permutation)
    {
        StringBuilder strPerm = new StringBuilder();

        strPerm.Append("{ ");

        for (int i = 0; i < permutation.Length; ++i)
        {
            strPerm.Append(permutation[i]).Append(" ");
        }

        strPerm.Append(" },");

        Console.WriteLine(strPerm.ToString());
    }
}


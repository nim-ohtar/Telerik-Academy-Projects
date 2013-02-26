/*
 * Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
 * Print the obtained array on the console.
 * 
 * */
using System;
using System.Text;

class IndexPlusFive
{
    static void Main(string[] args)
    {
        //The size of the array
        int size = 20;

        //The number by which the indexes will be miltiplied
        int multiply = 5;

        //Definition of the array
        int[] array = new int[size];

        //Variable for storing the result
        StringBuilder resultString = new StringBuilder("{ ");

        //Setting the values of the array and generating the result String
        for (int i = 0; i < size; ++i)
        {
            array[i] = i * multiply;

            resultString.Append(array[i]).Append(",");
        }

        resultString.Append("}");

        //Printing the Result
        Console.WriteLine("Result Array:" + resultString.ToString());

    }
}


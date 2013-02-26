//Program usng an array of lating letters and showing the indexes of the letters used in an entered word
using System;

class LatinLetters
{
    static void Main(string[] args)
    {
        string word = null;

        Console.WriteLine("Enter a word:");

        word = Console.ReadLine();

        char[] latinLetters = new char[52];

        //Adding values to the array of latin letter, capital and non capital letters
        for (int i = 0; i < 26; ++i)
        {
            latinLetters[i] = (char)(65 + i);

            latinLetters[i + 26] = (char)(97 + i);
        }

        char[] wordLetters = word.ToCharArray();

        for (int i = 0; i < wordLetters.Length; ++i)
        {
            for (int j = 0; j < latinLetters.Length; ++j)
            {
                if (wordLetters[i] == latinLetters[j])
                {
                    Console.Write("{0}({1}),", j, latinLetters[j]);
                }
            }
        }
    }
}


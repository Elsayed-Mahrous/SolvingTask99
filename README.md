1. Write a C# program that reads a list of integers from the user and throws an exception if any numbers are duplicates.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter integers separated by spaces:");
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            HashSet<int> numbers = new HashSet<int>();

            foreach (string token in tokens)
            {
                if (int.TryParse(token, out int number))
                {
                    if (!numbers.Add(number))
                    {
                        throw new Exception($"Duplicate number found: {number}");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input skipped: {token}");
                }
            }

            Console.WriteLine("All numbers are unique!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
2. Write a C# program to create a method that takes a string as input and throws an exception if the string does not contain vowels.
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            CheckForVowels(input);
            Console.WriteLine("The string contains at least one vowel.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void CheckForVowels(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            throw new Exception("Input string is empty.");

        string lowerText = text.ToLower();
        if (!(lowerText.Contains('a') || lowerText.Contains('e') || lowerText.Contains('i') || lowerText.Contains('o') || lowerText.Contains('u')))
        {
            throw new Exception("The string does not contain any vowels.");
        }
    }
}

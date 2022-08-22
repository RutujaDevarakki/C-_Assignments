
// C# program to count vowels in a string
using System;

class Program3
{

    // Function to check the Vowel
    public static bool isVowel(char ch)
    {
        ch = char.ToUpper(ch);
        return (ch == 'A' || ch == 'E' ||
                ch == 'I' || ch == 'O' ||
                              ch == 'U');
    }

    // Returns count of vowels in str
    public static int countVowels(string str)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {

            // Check for vowel
            if (isVowel(str[i]))
            {
                ++count;
            }
        }
        return count;
    }

    public static void Main(string[] args)
    {

        //string object
        string str = "rutuja";

        // Total numbers of Vowel
        Console.WriteLine(countVowels(str));
    }
}
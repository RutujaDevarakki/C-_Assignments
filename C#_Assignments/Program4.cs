// C# program to count no of words
using System;

class Program4
{

    static int OUT = 0;
    static int IN = 1;

    static int countWords(String str)
    {
        int state = OUT;
        int wc = 0; // word count
        int i = 0;

        while (i < str.Length)
        {
            if (str[i] == ' ' || str[i] == '\n' ||
                                  str[i] == '\t')
                state = OUT;

            else if (state == OUT)
            {
                state = IN;
                ++wc;
            }

            ++i;
        }

        return wc;
    }

    // Driver program to test above functions
    public static void Main()
    {
        String str = "Rutuja Devarakki ";
        Console.WriteLine("No of words : "
                              + countWords(str));
    }
}

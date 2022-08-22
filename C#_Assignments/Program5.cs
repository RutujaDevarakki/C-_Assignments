// C# program to interchange the first and last character of a string
using System;
using System.Collections.Generic;

public class Program5
{
    static void Main(string[] args)
    {
        Console.WriteLine(first_last("Rutuja"));
        Console.WriteLine(first_last("Devarakki"));
    }
    public static string first_last(string ustr)
    {
        return ustr.Length > 1
            ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
    }
}
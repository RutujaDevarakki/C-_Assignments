﻿static void Main(string[] args)
{
    int[] items = { 3, 5, 4, 2, 6, 8, 9 };
    int n = items.Length;

    Console.WriteLine("Unique array elements: ");

    for (int i = 0; i < n; i++)
    {
        bool isDuplicate = false;
        for (int j = 0; j < i; j++)
        {
            if (items[i] == items[j])
            {
                isDuplicate = true;
                break;
            }
        }

        if (!isDuplicate)
        {
            Console.WriteLine(items[i]);

        }
    }

    Console.ReadLine();
}

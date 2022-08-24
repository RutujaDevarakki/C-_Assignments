using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[100];

        int[] first = new int[100];
        int[] second = new int[100];

        int i, num;

        Console.WriteLine("Enter size of the array: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter elements in the array: ");
        for (i = 0; i < num; i++)
        {
            first[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < num; i++)
        {
            second[i] = first[i];
        }

        Console.WriteLine("Elements of first array are:");
        for (i = 0; i < num; i++)
        {
            Console.Write(first[i] + "\t");
        }

        Console.WriteLine("\nElements of second array are:");
        for (i = 0; i < num; i++)
        {
            Console.Write(second[i] + "\t");
        }

        Console.ReadLine();
    }

}


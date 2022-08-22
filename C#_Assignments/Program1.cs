
// C# program to print the small number
using System;
namespace smallno
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 50;
            int num2 = 90;
            int minNum;
            Console.WriteLine("Number 1: " + num1);
            Console.WriteLine("Number 2: " + num2);
            if (num1 < num2)
            {
                minNum = num1;
            }
            else
            {
                minNum = num2;
            }
            Console.WriteLine("Minimum number is: " + minNum);
            Console.ReadKey();
        }
    }
}
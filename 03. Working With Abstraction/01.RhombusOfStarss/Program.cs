using System;

namespace _01.RhombusOfStarss
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                PrintRow(i + 1, n - i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                PrintRow(i, n - i + 1);
            }
        }
    public static void PrintRow(int n, int intervals)
        {
            string result = "";
            result += new string(' ', intervals);
            for (int i = 0; i < n; i++)
            {
                result += "* ";
            }
            Console.WriteLine(result);
        }
    }
}
using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abc";
            text?.Insert(0, "sdsf");
            Console.WriteLine(text);
        }
    }
}

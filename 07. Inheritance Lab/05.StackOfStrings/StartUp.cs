using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();
            stackOfStrings.Push("1");
            stackOfStrings.Push("2");
            stackOfStrings.Push("3");
            stackOfStrings.Pop();
            stackOfStrings.Peek();
            while (!stackOfStrings.IsEmpty())
            {
                Console.WriteLine(stackOfStrings.Pop());
            }
        }
    }
}

using System;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            var stack = new StackOfStrings();

            stack.Push("Some text to push in the stack.");
            stack.Push("More text to push in the stack.");
            stack.Push("Another text to push in the stack.");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
        }
    }
}

using System;
using System.Collections;

class SimpleStack
{
    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (var obj in myCollection)
            Console.Write("    {0}", obj);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Last in First out collection
        Stack myStack = new Stack();
        myStack.Push("Hello");
        myStack.Push("World");
        myStack.Push("!!!");

        // Displays the properties and values of the Stack.
        Console.WriteLine("myStack");
        Console.WriteLine("\tCount:    {0}", myStack.Count);
        Console.Write("\tValues:");
        PrintValues(myStack);

    }
}

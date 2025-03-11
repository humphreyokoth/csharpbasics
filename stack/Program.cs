using System;
using System.Collections;


namespace stack
{

    public class SampleStack
    {

        public static void Main()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            Console.WriteLine("myStack");
            Console.WriteLine("\tCount:{0}", myStack.Count);
            Console.WriteLine("\tValues:");

            PrintValues(myStack);
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
            {
                Console.WriteLine("{0}", obj);

            }
        }
    }
}
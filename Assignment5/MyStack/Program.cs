﻿using System;
using System.Collections.Generic;
namespace GenericStack
{
    class MyStack
    {
        public static void Main()
        {
            try
            {
                Stack<object> numbers = new Stack<object>();
                numbers.Push("one");
                numbers.Push("2");
                numbers.Push("three");
                numbers.Push("4");
                numbers.Push("five");

                // A stack can be enumerated without disturbing its contents.
                foreach (object number in numbers)
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine("\nPopping '{0}'", numbers.Pop());
                Console.WriteLine("Peek at next item to destack: {0}",
                    numbers.Peek());
                Console.WriteLine("Popping '{0}'", numbers.Pop());

                // Create a copy of the stack, using the ToArray method and the
                // constructor that accepts an IEnumerable<T>.
                Stack<object> stack2 = new Stack<object>(numbers.ToArray());

                Console.WriteLine("\nContents of the first copy:");
                foreach (string number in stack2)
                {
                    Console.WriteLine(number);
                }

                // Create an array twice the size of the stack and copy the
                // elements of the stack, starting at the middle of the
                // array.
                string[] array2 = new string[numbers.Count * 2];
                numbers.CopyTo(array2, numbers.Count);

                // Create a second stack, using the constructor that accepts an
                // IEnumerable(Of T).
                Stack<object> stack3 = new Stack<object>(array2);

                Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
                foreach (object number in stack3)
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
                    stack2.Contains("four"));

                Console.WriteLine("\nstack2.Clear()");
                stack2.Clear();
                Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
    }
}
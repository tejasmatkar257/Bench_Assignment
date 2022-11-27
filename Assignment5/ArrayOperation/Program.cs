using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOperation
{
    class Program
    {
        public void integer()
        {
            Console.WriteLine("Enter Size of an Array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int[] arr2 = new int[size];

            Console.WriteLine("Enter Elements to the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Copy(arr, arr2, size);


            Console.WriteLine("Copy Elements:");
            foreach (int array in arr)
            {
                Console.WriteLine(array);
            }

            Array.Sort(arr);


            Console.WriteLine("Sort Elements");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

            Array.Clear(arr, 2, 2);


            Console.WriteLine("Clear Elements:");
            foreach (int n in arr)
            {
                Console.WriteLine(n);
            }

            Array.Reverse(arr);


            Console.WriteLine("Reverse Elements:");
            foreach (int b in arr)
            {
                Console.WriteLine(b);
            }
        }


        public void String()
        {
            Console.WriteLine("Enter Size of an Array:");
            int size = int.Parse(Console.ReadLine());


            string[] str = new string[size];
            string[] str2 = new string[size];

            Console.WriteLine("Enter Strings to the array:");

            for (int i = 0; i < size; i++)
            {
                str[i] = Console.ReadLine();
            }

            Array.Copy(str, str2, size);
            Console.WriteLine("Copy Strings:");

            foreach (string array in str)
            {
                Console.WriteLine(array);
            }


            Array.Sort(str);
            Console.WriteLine("Sort Strings:");

            foreach (string a in str)
            {
                Console.WriteLine(a);
            }

            Array.Clear(str, 1, 2);
            Console.WriteLine("Clear Strings:");

            foreach (string n in str)
            {
                Console.WriteLine(n);
            }

            Array.Reverse(str);
            Console.WriteLine("Reverse Strings:");

            foreach (string b in str)
            {
                Console.WriteLine(b);
            }

        }
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.integer();
            Console.WriteLine("---------------");
            p.String();

        }
    }
}
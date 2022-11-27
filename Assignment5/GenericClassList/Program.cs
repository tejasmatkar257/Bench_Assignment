using System;
using System.Collections.Generic;

namespace GenericClassList
{
    public class Employee<T>
    {
        // define an Array of Generic type with length 4
        T[] obj = new T[4];
        int count = 0;

        // adding items mechanism into generic type
        public void Add(T item)
        {
            //checking length
            if (count + 1 < 5)
            {
                obj[count] = item;

            }
            count++;
        }
        //indexer for foreach statement iteration
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //instantiate generic with String
            Employee<String> l1 = new Employee<String>();

            //adding integer values into collection
            l1.Add("vijji");
            l1.Add("Priyanka");
            l1.Add("Sharu");
            l1.Add("Sakshi");


            //displaying values
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine(l1[i]);
            }
            Console.ReadKey();
        }
    }
}
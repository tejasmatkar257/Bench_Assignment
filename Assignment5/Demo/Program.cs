using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> arr1 = new List<object>();
            arr1.Add("1");
            arr1.Add("Vijji");
            arr1.Add("5000");

            Console.WriteLine("Initial List ...");
            foreach (object i in arr1)
            {
                Console.WriteLine(i);
            }
            object[] arr2 = new object[4];
            arr2[0] = 2;
            arr2[1] = "Priyanka";
            arr2[2] = 8000;
            arr2[3] = 90;
            arr1.InsertRange(3, arr2);
            Console.WriteLine("After adding elements ...");
            foreach (object i in arr1)
            {
                Console.WriteLine(i);
            }
        }
    }
}

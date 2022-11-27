using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IteratorToIterate
{
    public class keySetIterator
    {
        public static void Main(String[] args)
        {

            foreach (object number in SomeNames())
            {
                Console.Write(number.ToString() + " ");

            }

            Console.ReadKey();
        }

        public static System.Collections.IEnumerable SomeNames()
        {
            Console.WriteLine("Player Details:");
            yield return "Virat";
            yield return "\nDhoni";
            yield return "\nRohit";
            yield return "\nYuvaraj";


        }
    }
}
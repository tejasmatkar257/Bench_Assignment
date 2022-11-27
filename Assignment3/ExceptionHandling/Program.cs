using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionHandling
{
    class StackException
    {

        private int div = -1;
        public int i;
        protected int j;
        public int[] ele;


        public void push()
        {
            try
            {
                Console.WriteLine("Enter Array Size:");
                j = Convert.ToInt32(Console.ReadLine());
                if (j >= 7)
                {
                    throw new IndexOutOfRangeException("Index Out Of Range Exception");
                    return;
                }
                ele = new int[j];
                Console.WriteLine("Enter Elements");
                for (i = 0; i < j; i++)
                {
                    ele[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception exce)
            {
                Console.WriteLine(exce.Message);
            }
            foreach (int rev in ele)
            {
                if (div >= j)
                {
                    Console.WriteLine("Error known");
                    return;
                }
                else
                {
                    ele[div++] = j;
                }
            }
        }
        public int pop()
        {
            if (div == -1)
            {
                Console.WriteLine("Eroor Unknown");
                return -1;
            }
            else
            {
                Console.WriteLine("Item popped from Stack :" + ele[div]);
                return ele[div--];

            }
        }

        class Run
        {
            static void Main(string[] args)
            {
                StackException se = new StackException();
                se.push();
                Console.WriteLine("Items in Stack are:");
                se.pop();
                Console.ReadLine();
            }
        }
    }
}
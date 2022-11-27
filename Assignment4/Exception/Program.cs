using System;

namespace Exception
{
    class Stack
    {
        private int[] ele;
        private int top;
        private int max;

        //Constructor initialize the variables || it calls as soon as object get created.
        public Stack(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }

        public void push(int item)
        {
            if (top == max - 1)
            {
                throw new Exception("Stack is Full");
            }
            else
            {
                ele[++top] = item;
            }
        }
        public int pop()
        {
            if (top == -1)
            {
                throw new Exception("Stacck is Empty");
            }
            else
            {
                Console.WriteLine("Poped element is " + ele[top]);
                return ele[top--];
            }
        }
        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "): " + ele[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            //Stack is class || S is object
            Stack S = new Stack(5);

            //objectname.methodname() -> to call the method inside the class
            S.push(101); // Last in First Out
            S.push(202);
            S.push(303);
            S.push(404);
            S.push(505);
            S.push(505);

            Console.WriteLine("Items are : ");
            S.printStack();

            S.pop();
            S.pop();
            S.pop();
            S.pop();
            S.pop();


        }
    }
}
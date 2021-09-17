using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StackDemo
    {
        public int[] stack; //array declaration
        public int top;
        public int max;

        public StackDemo(int size)
        {
            top = -1;
            max = size;
            stack = new int[max];
        }

        public void Push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack overflow");
                return;
            }
            //top = top + 1;
            //stack[top] = item;
            stack[++top] = item;
        }

        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            Console.WriteLine(stack[top] + " popped off");
            top--;
        }

        public void Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack underflow");
                return;
            }
            Console.WriteLine(stack[top] + " is the peek");
        }

        public void Print()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Stack elements are : ");
            for (int i = 0; i <= top; i++)
            {
                Console.Write(stack[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public class StackArrayImpl
    {
        public static void Main(string[] args)
        {
            StackDemo s = new StackDemo(5);

            s.Pop();
            s.Print();

            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Print();

            s.Push(6);
            s.Print();

            s.Pop();
            s.Peek();

            s.Push(7);
            s.Print();
            Console.ReadLine();
        }
    }
}

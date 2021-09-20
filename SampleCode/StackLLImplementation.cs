using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    //Stack implementation using linked list
    public class StackLLImpl
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        public void Push(int d)
        {
            Node newNode = new Node(d);
            newNode.next = head;
            head = newNode;
        }
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            head = head.next;
        }
        public void Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Peek element is " + head.data);
        }
        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Node ptr = head;
            Console.WriteLine("Elements in stack are : ");
            while (ptr != null)
            {
                Console.Write(ptr.data + " ");
                ptr = ptr.next;
            }
            Console.WriteLine();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            StackLLImpl stack = new StackLLImpl();
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Print items");
            do
            {
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter data");
                        int data = Convert.ToInt32(Console.ReadLine());
                        stack.Push(data);
                        break;
                    case 2:
                        stack.Pop();
                        Console.WriteLine("Popped off");
                        break;
                    case 3:
                        stack.Peek();
                        break;
                    case 4:
                        stack.Print();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (true);
        }
    }
}
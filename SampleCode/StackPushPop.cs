using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StackPushPop
    {
        static void Print(Stack<int> stack)
        {
            Console.Write("Stack elements : ");
            foreach (int elem in stack)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Print items");

            do
            {
                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                int data;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter data");
                        data = Convert.ToInt32(Console.ReadLine());
                        stack.Push(data);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        Print(stack);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                
                
            } while (true);
            
            Console.ReadLine();
        }
    }
}

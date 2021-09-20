using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
	//Link - https://www.geeksforgeeks.org/reverse-individual-words/
    public class Program
    {
        public static void ReverseWord(string str)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    stack.Push(str[i]);
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        Console.Write(stack.Pop());
                    }
                    Console.Write(" ");
                }
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
        public static void Main(string[] args)
        {
            ReverseWord("This is a stack Demo claSS");
            Console.ReadLine();
        }
    }
}
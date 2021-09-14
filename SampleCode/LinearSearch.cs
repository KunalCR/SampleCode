using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LinearSearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 80, 30, 60, 50, 110, 100, 130, 170 };
            int toFind = 160;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == toFind)
                {
                    Console.WriteLine("Found at position : " + i);
                    break;
                }
                if (i == arr.Length - 1)
                {
                    Console.WriteLine("Not found");
                }
            }
            Console.ReadLine();
        }
    }
}

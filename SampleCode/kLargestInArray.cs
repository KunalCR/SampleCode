using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    //Link - https://www.geeksforgeeks.org/k-largestor-smallest-elements-in-an-array/
    public class Program
    {
        static void kLargest(int[] arr, int k)
        {
            Array.Sort(arr);
            Console.WriteLine("K largest values");
            for (int i = arr.Length - k; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("K smallest values ");
            for (int i = 0; i < k; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Array.Reverse(arr);
            Console.WriteLine("K largest values");
            for (int i = 0; i < k; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("K smallest values ");
            for (int i = arr.Length - k; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 23, 12, 9, 30, 2, 50 };
            int k = 3;
            kLargest(arr, k);
            Console.ReadLine();
        }
    }
}
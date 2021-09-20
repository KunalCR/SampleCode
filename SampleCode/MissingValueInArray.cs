using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Link - https://www.geeksforgeeks.org/find-the-missing-number/
    public class Program
    {
        static int GetMissingValue(int[] arr)
        {
            int n = arr.Length;
            int total;

            total = ((n + 1) * (n + 2)) / 2;

            for (int i = 0; i < n; i++)
            {
                total -= arr[i];
            }

            return total;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 6, 3, 7 };
            Console.WriteLine("Missing value is " + GetMissingValue(arr));
            Console.ReadLine();
        }
    }
}

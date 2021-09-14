using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MoveZerosEnd
    {
        /*
         * Link : https://www.geeksforgeeks.org/move-zeroes-end-array/
         */
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 4, 3, 0, 5, 0 };
            int count = 0; // count non zero values
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count++] = arr[i];
                }
            }
            for (int i = count; i < arr.Length; i++)
            {
                arr[i] = 0;
            }

            Console.WriteLine("Array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}

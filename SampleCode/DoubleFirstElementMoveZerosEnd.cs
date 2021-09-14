using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DoubleFirstElementMoveZerosEnd
    {
        /*
         * Link : https://www.geeksforgeeks.org/double-first-element-move-zero-end/
         */
        static void Main(string[] args)
        {
            int[] arr = { 0, 2, 2, 2, 0, 6, 6, 0, 0, 8 };

            int count = 0; // count non zero values
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] != 0 && arr[i] == arr[i + 1])
                {
                    arr[i] *= 2;
                    arr[i + 1] = 0;
                    i++;
                }                
            }

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

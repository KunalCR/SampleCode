using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReverseArray
    {
        /*
         * Link : https://www.geeksforgeeks.org/write-a-program-to-reverse-an-array-or-string/
         */
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6};
            int last = arr.Length - 1;
            for (int i = 0; i < arr.Length/2; i++)
            {
                if (i <= last)
                { 
                    int temp = arr[i];
                    arr[i] = arr[last];
                    arr[last] = temp;
                    last--;
                }
            }
            Console.WriteLine("Reversed array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BinarySearch
    {

        static int Search(int low, int high, int toFind, int[] arr)
        {
            if (low <= high) 
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == toFind)
                {
                    return mid;
                }
                else
                {
                    if (arr[mid] < toFind)
                    {
                        return Search(mid + 1, high, toFind, arr);
                    }
                    else
                    {
                        return Search(low, mid - 1, toFind, arr);
                    }
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int toFind = 10;
            int high = arr.Length - 1;

            int index = Search(0, high, toFind, arr);

            if (index == -1)
            {
                Console.WriteLine("Element not present");
            }
            else 
            { 
                Console.WriteLine("Element found at index " + index); 
            }
                
            Console.ReadLine();
        }
    }
}

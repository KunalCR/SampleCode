using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    /// <summary>
    ///  Link - https://www.geeksforgeeks.org/count-number-of-occurrences-or-frequency-in-a-sorted-array/
    /// </summary>
    public class Program
    {
        static int Search(int low, int high, int toFind, int[] arr) // Binary search
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
        static int CountOccurenceBinarySearch(int[] arr, int n, int element)
        {
            int index = Search(0, n, element, arr);
            if (index == -1) //element is not present
            {
                return 0;
            }
            int count = 1;
            int left = index - 1;
            while (left >= 0 && arr[left] == element) //count elements on left side
            {
                count++;
                left--;
            }
            int right = index + 1;
            while (right < n && arr[right] == element) //count element on right side
            {
                count++;
                right++;
            }
            return count;
        }
        static int CountOccurence(int[] arr, int n, int element) // Linear search
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == element)
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 2, 2, 2, 3, 3, 3, 4, 4 };
            int element = 2;
            int n = arr.Length;
            //Linear search
            if (CountOccurence(arr, n, element) == 0)
            {
                Console.WriteLine("Element not available");
            }
            else
            {
                int count = CountOccurence(arr, n, element);
                Console.WriteLine("Element " + element + " is occuring " + count + " times using linear search.");
            }
            //Binary Search
            if (CountOccurenceBinarySearch(arr, n, element) == 0)
            {
                Console.WriteLine("Element not available");
            }
            else
            {
                int frequency = CountOccurenceBinarySearch(arr, n, element);
                Console.WriteLine("Element " + element + " is occuring " + frequency + " times using binary search.");
            }
            Console.ReadLine();
        }
    }
}
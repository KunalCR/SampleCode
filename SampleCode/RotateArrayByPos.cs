using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    class RotateArrayByPos
    {
        /**
            Link - https://www.geeksforgeeks.org/array-rotation/
        **/
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int pos = 3;
            int[] temp = new int[7];
            int count = 0;
            for (int i = pos; i < 7; i++)
            {
                temp[count] = arr[i];
                count++;
            }
            for (int i = 0; i < pos; i++)
            {
                temp[count] = arr[i];
                count++;
            }
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(temp[i]);
            }
            Console.ReadLine();
        }
    }
}

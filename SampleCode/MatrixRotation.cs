using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MatrixRotation
    {
        static int[,] RotateAntiClockwise(int[,] arr)
        {
            var temp = new int[3, 3];
            int n = 3;

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    temp[i, j] = arr[n - 1 - i, j];
                }
            }

            return temp;
        }
        static int[,] RotateClockwise(int[,] arr)
        {
            int[,] temp = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    temp[i, j] = arr[j, i];
                }
            }
            return temp;
        }
        static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] array1 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //clockwise
            int[,] rotatedArray = RotateClockwise(array1);
            Console.WriteLine("Rotated array clockwise");
            PrintArray(rotatedArray);

            //anticlockwise
            int[,] rotatedArrayAnticlockwise = RotateAntiClockwise(rotatedArray);
            Console.WriteLine("Rotated array anticlockwise");
            PrintArray(rotatedArrayAnticlockwise);
            Console.ReadLine();
        }
    }
}

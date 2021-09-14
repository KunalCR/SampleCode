using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MatrixMultiplication
    {        
        static void Main(string[] args)
        {
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array3 = new int[3, 3];

            Console.WriteLine("Enter elements in array1");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter elements in array2");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //multiplication
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array3[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        array3[i, j] = array3[i, j] + array1[i, k] * array2[k, j];
                    }
                }
            }

            Console.WriteLine("Result matrix is ");
            for (int i = 0; i < 3; i++) // row
            {
                for (int j = 0; j < 3; j++) // col
                {
                    Console.Write(array3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

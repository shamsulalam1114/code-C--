using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[][] jaggedArray = new int[3][]; // Initialize jagged array with 3 rows
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 4, 5, 7 };
            jaggedArray[2] = new int[] { 9, 2, 5, 6 };
            // Removed jaggedArray[3] assignment to avoid index out of range error

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.WriteLine($"{jaggedArray[row][col]} ");
                }
            }

            Console.ReadLine(); // Keep console open*/

            int[][] jaggedArray =
            {
                new []{1,2, 3, 4},
                new []{3,6,8 }

            };
            foreach (var row in jaggedArray)
            {
                foreach (var item in row)
                {
                    Console.WriteLine($"{item}");

                }









            }
        }

    }
}
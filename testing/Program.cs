using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondday
{
    class Risa
    {
        public int Id;
        public string Name;
        public const int age = 16;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] jarray = new int[3][];
            //for (int i = 0; i < jarray.Length; i++) {
            //    for (int j = 0; j < jarray[i].Length; j++) { 
            //    int j2 = jarray[i][j];

            //    }
            //}

            //Risa risa = new Risa();
            //risa.age=20;
            //risa.Name = "Sumaiya";
            //risa.Id = 23467;
            //Risa risa1 = risa;
            //Risa risa2 = risa;

            int[,] arr = new int[5, 3];
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int len = arr.GetLength(0);
            int len2 = arr.GetLength(1);
            Console.WriteLine(len + " " + len2);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (int item in arr2)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();

        }
    }
}
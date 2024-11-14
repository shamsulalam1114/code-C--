using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=10;i>=1;i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("enter the last number");
            int lastNum=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<lastNum; i=i+10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

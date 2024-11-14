using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_cvase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number= Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case int num when num % 2==0:
                    Console.WriteLine($"even number");
                    break;
                case int num when num % 2 != 0:
                    Console.WriteLine($"odd number");
                    break;
                    default:
                    Console.WriteLine($"number is out of range");
                    break;

            }
        }
    }
}

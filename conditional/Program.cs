using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("enter ther X:");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 10)
            { Console.WriteLine("x is greater"); }
            else { Console.WriteLine("x is smaller"); }

            char letter;
            Console.WriteLine("enter the letter");
            letter = Convert.ToChar(Console.ReadLine());

            if (letter >= 'A' && letter <= 'Z')
            { Console.WriteLine("capital"); }
            else
            {
                Console.WriteLine("small");
            }

            switch (letter)
            {
                case 'A':
                    Console.WriteLine("printed A");
                    break;
                case 'B':
                    Console.WriteLine("printed B");
                    break;
            }
        }
        }
    }


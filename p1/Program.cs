using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1=1;
            int num2=2;
            int result;
            double div=(double)num1/(double)num2;
            
            result = num1 + num2;
            Console.WriteLine($"{num1}+ {num1}= {result}");
            Console.WriteLine($"{num1}/{num1}= {div.ToString("F6")}");
            Console.WriteLine("{0}/{1}= {2}", num1,num2,div);

            int a, b, c;
            double avg;
            Console.WriteLine("enter a:");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter b:");
            b = Convert.ToInt32(Console.ReadLine());

            

            c = a + b;
            Console.WriteLine(c);

            avg = (double)c / 3;
            Console.WriteLine(avg.ToString("F4"));


        }

    }
}

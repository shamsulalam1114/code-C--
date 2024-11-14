using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tri, Base, Height,result;

            Console.WriteLine("enter base :");
            Base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter Height :");
            Height = Convert.ToDouble(Console.ReadLine());

            
            tri = 0.5 * Base * Height;
            Console.WriteLine($"temperatrure={tri:F2}");


            int g = 10;
            g += 5;
            Console.WriteLine("value of g: "+ g);

            result= tri > Base ? Height : Base;
            Console.WriteLine(result);

        }
    }
}

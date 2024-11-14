using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit;
            Console.WriteLine("write a digit");
            digit = Convert.ToInt32(Console.ReadLine());

            switch(digit)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;

                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;

                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;

                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;

                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;

                case 9:
                    Console.WriteLine("nine");
                    break;
                

                default:
                    Console.WriteLine("not a single digit");
                    break;
            }


            char letter;
            Console.WriteLine("enter a letter");
            letter = Convert.ToChar(Console.ReadLine());

            switch(Char.ToLower(letter))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"{letter} is a vowel");
                    break;
                default:
                    if(char.IsLetter(letter))
                    {
                        Console.WriteLine($"{letter} is consonent");
                    }
                    else
                    {
                        Console.WriteLine("is not a letter");
                    }
                    break;  

            }


           string day;
            Console.WriteLine("enter a day");
            day = (Console.ReadLine());

            switch (day.ToLower())
            {
                case "sunday":
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                    Console.WriteLine($"{day} is a weekday");
                    break;
                case "friday":
                case "saturday":
                    Console.WriteLine($"{day} is a weekend day");
                    break;
                default:
                    Console.WriteLine("not a valid day");
                    break;

            }
            int digit2 = 1;
            string message = digit2 switch
            {
                1 => "one",
                _ => "unknown" 
            };

            Console.WriteLine($"{message}");
            Console.ReadLine();
        }
    }
}

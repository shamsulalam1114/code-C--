using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("Select the conversion you want to perform:");
            Console.WriteLine("1: Celsius to Fahrenheit");
            Console.WriteLine("2: Celsius to Kelvin");
            Console.WriteLine("3: Fahrenheit to Celsius");
            Console.WriteLine("4: Fahrenheit to Kelvin");
            Console.WriteLine("5: Kelvin to Celsius");
            Console.WriteLine("6: Kelvin to Fahrenheit");
            Console.Write("Enter your choice (1-6): ");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter the temperature to convert: ");
            double inputTemperature = double.Parse(Console.ReadLine());
            double convertedTemperature;

            switch (choice)
            {
                case 1:
                    // Celsius to Fahrenheit
                    convertedTemperature = (inputTemperature * 9 / 5) + 32;
                    Console.WriteLine($"{inputTemperature}°C is {convertedTemperature}°F");
                    break;

                case 2:
                    // Celsius to Kelvin
                    convertedTemperature = inputTemperature + 273.15;
                    Console.WriteLine($"{inputTemperature}°C is {convertedTemperature}K");
                    break;

                case 3:
                    // Fahrenheit to Celsius
                    convertedTemperature = (inputTemperature - 32) * 5 / 9;
                    Console.WriteLine($"{inputTemperature}°F is {convertedTemperature}°C");
                    break;

                case 4:
                    // Fahrenheit to Kelvin
                    convertedTemperature = (inputTemperature - 32) * 5 / 9 + 273.15;
                    Console.WriteLine($"{inputTemperature}°F is {convertedTemperature}K");
                    break;

                case 5:
                    // Kelvin to Celsius
                    convertedTemperature = inputTemperature - 273.15;
                    Console.WriteLine($"{inputTemperature}K is {convertedTemperature}°C");
                    break;

                case 6:
                    // Kelvin to Fahrenheit
                    convertedTemperature = (inputTemperature - 273.15) * 9 / 5 + 32;
                    Console.WriteLine($"{inputTemperature}K is {convertedTemperature}°F");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}

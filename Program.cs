﻿using System;

namespace _02.FahrenheitToCelsiusConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Body temperature in Fahrenheit degrees : ");
            double temperatureInFahrenheit = Double.Parse(Console.ReadLine());

            double temperatureInCelsius = FahrenheitToCelsius(temperatureInFahrenheit); //assigning methods result /
            Console.WriteLine("your body temperature in Celsius degrees is {0}",
                                temperatureInCelsius);

            SayIfYouAreIll(temperatureInCelsius);
        }
        static double FahrenheitToCelsius(double degrees)
        {
            return ((degrees - 32) * 5 / 9);  //we write the mehtos formula to calculate form fahrenheit degree to celsius degree
                                              //(32°F − 32) × 5/9 = 0°C formula
        }
        static void SayIfYouAreIll(double temperatureInCelsius)
        {
            if (temperatureInCelsius >= 37) //check it temperatureIn Celsius 
            {
                Console.WriteLine("You might be ill ");
            }
            else if (temperatureInCelsius <= 27)
            {
                Console.WriteLine("You have Hypothermia and may be  get ill, please go to a warmer place!  ");
            }
        }
    }
}

/// Chapter No. 2		Exercise No. 2
/// File Name: HW2Part2.cs
/// @author: Jacques Zwielich 
/// Date:  September 13, 2020
///
/// Problem Statement: A program that converts degrees Fahrenheit to Celsius using the following formula.
/// 
/// 
/// 
/// Overall Plan:
/// 1) Ask user for temperature in F
/// 2) Read and convert to double users response
/// 3) Apply conversion formula and store in degreec
/// 4) Round to the nearest first decimal
/// 5) Print out the degrees in Celcius

using System;

namespace HW2Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreesC;
            Console.Write("Please enter a temperature in Fahrenheit: ");
            double degreesF = Convert.ToDouble(Console.ReadLine());
            degreesC = (degreesF - 32.0) * 5.0 / 9;
            degreesC = Math.Round(degreesC, 1);
            Console.WriteLine("Celcius:" + degreesC);



        }
    }
}

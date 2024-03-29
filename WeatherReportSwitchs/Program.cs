﻿using System;

namespace WeatherReportSwitchs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu kraadi õues on.");
            int temp = Convert.ToInt32(Console.ReadLine());

            switch (temp)
            {
                case var _ when temp < 0:
                    Console.WriteLine("Freezin cold");
                    break;
                case var _ when temp >= 0 && temp < 10:
                    Console.WriteLine("Cold");
                    break;
                case var _ when temp >= 10 && temp < 20:
                    Console.WriteLine("Chilly");
                    break;
                case var _ when temp >= 20 && temp < 30:
                    Console.WriteLine("Nice");
                    break;
                case var _ when temp >= 30 && temp < 35:
                    Console.WriteLine("Hot");
                    break;
                default:
                    Console.WriteLine("Boiling hot");
                    break;
            } 
            
        }
    }
}

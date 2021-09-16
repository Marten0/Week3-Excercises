using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu kraadi õues on.");
            int Kraad = Convert.ToInt32(Console.ReadLine());

            if (Kraad >= 35)
            {
                Console.WriteLine("Boiling Hot.");
            }
            else if (Kraad >= 30 && Kraad < 35 )
            {
                Console.WriteLine("Hot");
            }
            else if (Kraad >= 20 && Kraad < 30 )
            {
                Console.WriteLine("Nice");
            }
            else if (Kraad >= 10 && Kraad < 20)
            {
                Console.WriteLine("Chilly");
            }
            else if (Kraad >= 0 && Kraad < 10 )
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("Freezin cold.");
            }
        }
    }
}

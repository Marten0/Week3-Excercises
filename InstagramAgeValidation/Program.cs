using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on su sünniaasta");
            int Sünniaasta = Convert.ToInt32(Console.ReadLine());
            int Vanus = 2021 - Sünniaasta;

            if (Vanus >= 13)
            {
                Console.WriteLine("Saad teha Instagrami kasutaja.");
            }
            else if (Vanus < 13)
            {
                Console.WriteLine("Ei saa teha Instagrami kasutajat.");
            }
        }
    }
}

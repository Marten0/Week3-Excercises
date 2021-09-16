using System;

namespace AndExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks;
            //miinimum matemaatikas 85;
            //miinimum keemias 90;
            //miinimum bioloogias 95;
            //programm küsib kasutajal sisestada tema
            //eksami punktid ja otsustab, kas kasutaja
            //saab arstiks õppida

            Console.WriteLine("Sisesta oma Matemaatika punktid");
            int Math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma Keemia punktid");
            int Chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma Bioloogia punktid");
            int Bio = Convert.ToInt32(Console.ReadLine());

            if (Math >= 85 && Chem >= 90 && Bio >= 95)
            {
                Console.WriteLine("Saad sisse!");
            }
            else
            {
                Console.WriteLine("Ei saa sisse.");
            }

        }
    }
}

using System;

namespace Week3_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada PIN koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //programm kuvab konsoolis "Tere tulemast!"
            //kui sisestatud PIN on vale , programm kuvab konsoolis
            //"Vale PIN. proovi uuesti."

            Console.WriteLine("Sisestage PIN-Kood.");
            int PIN = Convert.ToInt32(Console.ReadLine());

            /*if (PIN == 1234)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale PIN. proovi uuest.");
            }*/

            if (PIN != 1234)
            {
                Console.WriteLine("Vale PIN. Proovi uuest.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}

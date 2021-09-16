using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja parool
            //programm kontrollib sisestatud andmed
            //kui sisestatud kasutaja tunnus on "admin ja parool "admin1234"
            //siis programm kuvab "tere tulemast"
            //muul juhul programm kuvab "Vale kasutaja tunnus või parool. Proovi uuest."

            Console.WriteLine("Sisesta Kasutajatunnus.");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta Parool.");
            string Password = Console.ReadLine();

            /*if (userName == "admin" && Password == "admin1234")
            {
                Console.WriteLine("tere tulemast");
            }
            else
            {
                Console.WriteLine("Vale kasutaja tunnus või parool. Proovi uuest.");
            }*/
            if (userName != "admin" || Password != "admin1234")
            {
                Console.WriteLine("Vale kasutaja tunnus või parool. Proovi uuest.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}

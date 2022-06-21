using System;

namespace MyFirstProgram
{
    class Program
    {
        // esre@avansplus.nl
        
        static void Main(string[] args)
        {
            Console.Write("Wachtwoord invullen: ");
            var wachtwoord = Console.ReadLine();
            if (wachtwoord == "security")
            {
                Console.Write("Voer hier uw naam in: ");
                var naampersoon = Console.ReadLine();
                Console.Write("Voer hier uw leeftijd in: ");
                var leeftijdpersoon = Console.ReadLine();
                Console.Write("voer hier uw geboorte maand in: ");
                var gebMaandPersoon = Console.ReadLine();

                Console.WriteLine("\n\n{0}\n{1}\n{2}", naampersoon, leeftijdpersoon, gebMaandPersoon);

                if (gebMaandPersoon == "april")
                {
                    Console.WriteLine("Uw sterrenbeeld is: Ram");
                }
                if (gebMaandPersoon == "mei")
                {
                    Console.WriteLine("Uw sterrenbeeld is: Stier");
                }

                if (gebMaandPersoon == "juni")
                {
                    Console.WriteLine("Uw sterrenbeeld is: Tweeling");
                }
            }
            else if (wachtwoord != "security" ) 
            {
                Console.WriteLine("Ongeldig wachtwoord gebruikt");
            }

         




            /*
             * ram - april
             * stier - mei
             * tweeling - juni
             */

            /*
            Console.Write("voer aub jouw gedag in: ");
            var gedag = Console.ReadLine();
            Console.WriteLine("\n\n{0}",gedag);
            */
        }
    }
}
                                       
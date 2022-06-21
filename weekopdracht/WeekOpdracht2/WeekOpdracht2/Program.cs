using System;

namespace BakkerijSystem
{
    /// <summary>
    /// RCS1102
    /// </summary>
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // de bakkerij heeft 2 inkopers, 3 verkopers, 1 manager            
            //data
            var version = ("versie 2.03.06.1 AF");  //cursus week: 2 vacatures: 3, medewerkers: 6, aantal bakkerijen: 1, Array: A, Function: F
            var username = "";
            var wachtwoord = "";
            var keuze = "";
            var keuze2 = "";
            var personeelfunctie = "";

            //bakkerij
            var bakkerijnaam = "Bakkerij Fierce Flour";

            //klanten en bestellingen - array

            //gegevens medewerkers
            //manager stats
            var managernaam = "Naam: Drystan Furor";
            var manageradres = "Adres: Himdall Hordplein 184";
            var managerloon = "Dienstverband: 20+ jaar ervaring, \nKaderlid-functie: senior managers; \nSalaris 6373,- ";

            //inkoper stats
            var inkoper01naam = "Naam: Parthenas Virgilius Maro";
            var inkoper01adres = "Adres: Gan Coileáin weg 162";
            var inkoper01loon = "Dienstverband: 10+ jaar ervaring,  \nFunctie: tactisch inkoper; \nSalaris 5769,23 ";

            var inkoper02naam = "Naam: Celaralindë Tarnir";
            var inkoper02adres = "Adres: Ronodrilstraat 110";
            var inkoper02loon = "Dienstverband: 3+ jaar ervaring, \nFunctie: operationeel inkoper; \nSalaris 3269,23 ";

            //verkoper stats
            var verkoper01naam = "Naam: Malthael Chalad'ar";
            var verkoper01adres = "Adres: Angiris Raadsplein 21";
            var verkoper01loon = "Dienstverband: 16 jaar ervaring, \nFunctie: Verkoopmedewerker; \nSalaris 2.863,93 ";

            var verkoper02naam = "Naam: Jester van Falconia";
            var verkoper02adres = "Adres: Steenbaai 34";
            var verkoper02loon = "Dienstverband: 14 jaar ervaring,\nFunctie: Verkoopmedewerker; \nSalaris 2.263,93 ";

            var verkoper03naam = "Naam: Elmira Elbage";
            var verkoper03adres = "Adres: Belkora Boslaan 168";
            var verkoper03loon = "Dienstverband: 1 jaar ervaring, \nFunctie: Verkoopmedewerker; \nSalaris 1.863,93 ";

            //datum en tijd
            int mon = DateTime.Today.Month;
            int da = DateTime.Today.Day;
            int yer = DateTime.Today.Year;
            var time = DateTime.Now;

            Console.Write(da);
            Console.Write("." + mon);
            Console.WriteLine("." + yer);
            Console.WriteLine("als u problemen hebt met inloggen, vraag dan uw manager om hulp.");
            Console.WriteLine("Vul om te beginnen je Gebruikersnaam en wachtwoord in, zoals deze bij u bekend is.\n\n");

            //login
            Console.WriteLine("GEBRUIKERSNAAM");
            while (username != "Bakkerij")
            {
                Console.Write("> ");
                username = Check();
                if (username != "Bakkerij")
                {
                    Console.WriteLine("Gebruikersnaam onbekend, probeer nogmaals");
                }
            }
            Console.WriteLine("WACHTWOORD");

            // login wachtwoord
            while (wachtwoord != "security")
            {
                Console.Write("> ");
                wachtwoord = Check();
                if (wachtwoord != "security")
                {
                    Console.WriteLine("Wachtwoord is niet correct, probeer nogmaals");
                }
            }
            //begroeting
            Console.WriteLine("\nSystem van " + bakkerijnaam);
            Console.WriteLine(version);

            //wat wilt u doen, klant bestellingen of werknemer gegevens
            Console.WriteLine("\n\nWat wilt u doen?\n  1. Klanten bestellingen opgeven. \n  2. Gegevens medewerkers inzien\n");
            Console.Write("Keuze 1 of 2\n> ");

            while (keuze != "1" && keuze != "2")
            {
                Console.Write("> ");
                keuze = Check();
                if (keuze != "1" && keuze != "2")
                {
                    Console.Write("Invoer ongeldig, kies 1 of 2\n> ");
                }
            }

            //keuze 1 - klant en bestelling
            if (keuze == "1")
            {
                Console.Write("Hoeveel bestellingen wilt u maken?\n> ");
                var totaalbestellingen = int.Parse(Console.ReadLine());
                var bestelling = new string[totaalbestellingen];
                var klantnaam = new string[totaalbestellingen];

                for (int i = 0; i < totaalbestellingen; i++)
                {
                    Console.WriteLine("Noteer klantnaam: \n> ");
                    klantnaam[i] = Console.ReadLine();
                    Console.WriteLine("Noteer bestelling: \n> ");
                    bestelling[i] = Console.ReadLine();
                }

                for (int i = 0; i < totaalbestellingen; i++)
                {
                    Console.WriteLine("Klantnaam: {0} \nBestelling: {1}", klantnaam[i], bestelling[i]);
                }
            }

            //keuze 2, gegevens inzien, welke gegevens, 1 of 2
            if (keuze == "2")
            {
                Console.WriteLine("\n\nWelke gegevens wilt u zin?\n  1. Adressen Bestand Medewerkers. \n  2. Gegevens medewerkers inzien\n");
                Console.Write("Keuze 1 of 2\n> ");

                while (keuze2 != "1" && keuze2 != "2")
                {
                    Console.Write("> ");
                    keuze2 = Check();
                    if (keuze2 != "1" && keuze2 != "2")
                    {
                        Console.Write("Invoer ongeldig, kies 1 of 2\n> ");
                    }
                }
            }

            if (keuze2 == "1")
            {
                Console.WriteLine("\n{0}\n{1}", managernaam, manageradres);
                Console.WriteLine("\n{0}\n{1}", inkoper01naam, inkoper01adres);
                Console.WriteLine("\n{0}\n{1}", inkoper02naam, inkoper02adres);
                Console.WriteLine("\n{0}\n{1}", verkoper01naam, verkoper01adres);
                Console.WriteLine("\n{0}\n{1}", verkoper02naam, verkoper02adres);
                Console.WriteLine("\n{0}\n{1}", verkoper03naam, verkoper03adres);
            }

            // werknemer gegevens KEUZE 2
            if (keuze2 == "2")
            {
                //wachtwoord -> functie->  persoonsgegevens
                Console.WriteLine("\nManager \nVerkoper01 \nVerkoper02 \nVerkoper03 \nInkoper01 \nInkoper02");
                Console.WriteLine("\n\nWelke werknemer gegevens wilt u inzien? \n(Kies uit bovenstaande, Hoofdlettergevoelig)"); //functie vaststellen
                while (personeelfunctie != "Manager" && personeelfunctie != "Verkoper01" && personeelfunctie != "Verkoper02" && personeelfunctie != "Verkoper03" && personeelfunctie != "Inkoper01" && personeelfunctie != "Inkoper02")
                {
                    personeelfunctie = Check();
                    if (personeelfunctie != "Manager" && personeelfunctie != "Verkoper01" && personeelfunctie != "Verkoper02" && personeelfunctie != "Verkoper03" && personeelfunctie != "Inkoper01" && personeelfunctie != "Inkoper02")
                        Console.Write("Invoer ongeldig. probeer het nogmaals:\n> ");
                }

                //manager
                if (personeelfunctie == "Manager")//manager
                {
                    Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", managernaam, manageradres, managerloon, time);
                }

                //inkopers
                if (personeelfunctie == "Inkoper01")//inkoper01
                {
                    Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", inkoper01naam, inkoper01adres, inkoper01loon, time);  // resultaat 
                }

                if (personeelfunctie == "Inkoper02")//inkoper02
                {
                    Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", inkoper02naam, inkoper02adres, inkoper02loon, time);  // resultaat 
                }

                //verkopers
                if (personeelfunctie == "Verkoper01")//verkoper01
                {
                    Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", verkoper01naam, verkoper01adres, verkoper01loon, time);  // resultaat 
                }

                if (personeelfunctie == "Verkoper02")//verkoper02
                {
                    Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", verkoper02naam, verkoper02adres, verkoper02loon, time);  // resultaat
                }

                if (personeelfunctie == "Verkoper03")//verkoper03
                {
                    Console.WriteLine("\n\n{0}\n{1}\n{2}\n{3}", verkoper03naam, verkoper03adres, verkoper03loon, time);  // resultaat 
                }
            }
        }

        private static string Check()

        {
            string vraag = Console.ReadLine();

            if (vraag == "")

            {
                Console.Write("Invoer ongeldig. probeer het nogmaals:\n> ");

                vraag = Console.ReadLine();
            }

            return vraag;
        }
    }
}
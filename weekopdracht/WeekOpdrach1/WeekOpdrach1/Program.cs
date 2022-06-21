using System;

namespace BakkerijSystem
{
    /// <summary>
    /// RCS1102
    /// </summary>
    static class Program
    {
        static void Main(string[] args)
        {
            /* de bakkerij heeft 2 inkopers, 3 verkopers, 1 manager
             * app gebruikt IF statement om vast te stellen
             */
            //data
            var version = ("versie 0.03.06.1");  //cursus week: 0 vacatures: 3, medewerkers: 6, aantal bakkerijen: 1


            //bakkerij
            var bakkerijnaam = "Bakkrij Fierce Flour";
            var wachtwoord = "";

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
            var verkoper02loon = "Huidig Dienstverband: 14 jaar ervaring,\nFunctie: Verkoopmedewerker; \nSalaris 2.263,93 ";

            var verkoper03naam = "Naam: Elmira Elbage";
            var verkoper03adres = "Adres: Belkora Boslaan 168";
            var verkoper03loon = "Loon: 1 jaar ervaring, \nFunctie: Verkoopmedewerker; \nSalaris 1.863,93 ";

            //datum en tijd
            int mon = DateTime.Today.Month;
            int da = DateTime.Today.Day;
            int yer = DateTime.Today.Year;
            var time = DateTime.Now;

            Console.Write(da);
            Console.Write("." + mon);
            Console.WriteLine("." + yer);

            //begroeting
            Console.WriteLine("System van " + bakkerijnaam);
            Console.WriteLine(version);
            Console.WriteLine("Vul om te beginnen het wachtwoord in, zoals deze bij u bekend is.");
            Console.WriteLine("als u problemen hebt met inloggen, vraag dan uw manager om uw gegevens.\n\n");


            /*Console.Write("Voer uw wachtwoord in: ");
            while (wachtwoord != "security") ;
            { 
            wachtwoord = Console.ReadLine();
            
                Console.WriteLine("Wachtwoord is incorrect");

            }*/

            //functie naar wachtwoord naar persoonsgegevens
            Console.WriteLine("Manager \nVerkoper01 \nVerkoper02 \nVerkoper03 \nInkoper01 \nInkoper02");
            Console.WriteLine("\n\nWat is uw functie? (Kies uit bovenstaande, Hoofdlettergevoelig)"); //functie vaststellen
            var functieGebruiker = Console.ReadLine();

            //manager
            if (functieGebruiker == "Manager")//manager
            {
                Console.Write("Wachtwoord invullen: "); //functie als wachtwoord
                wachtwoord = Console.ReadLine();
                if (wachtwoord == "manager01")            //controle wachtwoord
                {
                    Console.Write("\n\nWelkom manager " + managernaam); // resultaat bij juiste invoer
                    Console.Write(" , hier zijn uw gegevens: \n\n");
                    Console.WriteLine("\n{0}\n{1}\n{2}", managernaam, manageradres, managerloon);
                    Console.WriteLine(time);
                }
                else
                {
                    Console.WriteLine("U heeft helaas een ongeldig wachtwoord gebruikt.");//verkeerde wachtwoord
                }
            }

            //inkopers
            if (functieGebruiker == "Inkoper01")//inkoper01
            {
                Console.Write("Wachtwoord invullen: "); //functie als wachtwoord
                wachtwoord = Console.ReadLine();
                if (wachtwoord == "inkoper01")            //controle wachtwoord
                {
                    Console.Write("\n\nWelkom inkoper " + inkoper01naam); // groet bij juiste invoer
                    Console.Write(" , hier zijn uw gegevens: \n\n");
                    Console.WriteLine("\n{0}\n{1}\n{2}", inkoper01naam, inkoper01adres, inkoper01loon);  // resultaat bij juiste invoer
                    Console.WriteLine(time);
                }
                else
                {
                    Console.WriteLine("U heeft helaas een ongeldig wachtwoord gebruikt.");//verkeerde wachtwoord
                }
            }
            if (functieGebruiker == "Inkoper02")//inkoper02
            {
                Console.Write("Wachtwoord invullen: "); //functie als wachtwoord
                wachtwoord = Console.ReadLine();
                if (wachtwoord == "inkoper02")            //controle wachtwoord
                {
                    Console.Write("\n\nWelkom inkoper " + inkoper02naam); // groet bij juiste invoer
                    Console.Write(" , hier zijn uw gegevens: \n\n");
                    Console.WriteLine("\n{0}\n{1}\n{2}", inkoper02naam, inkoper02adres, inkoper02loon);  // resultaat bij juiste invoer
                    Console.WriteLine(time);
                }
                else
                {
                    Console.WriteLine("U heeft helaas een ongeldig wachtwoord gebruikt.");//verkeerde wachtwoord
                }
            }

            //verkopers
            if (functieGebruiker == "Verkoper01")//verkoper01
            {
                Console.Write("Wachtwoord invullen: "); //functie als wachtwoord
                wachtwoord = Console.ReadLine();
                if (wachtwoord == "verkoper01")            //controle wachtwoord
                {
                    Console.Write("\n\nWelkom verkoper " + verkoper01naam); // groet bij juiste invoer
                    Console.Write(" , hier zijn uw gegevens: \n\n");
                    Console.WriteLine("\n{0}\n{1}\n{2}", verkoper01naam, verkoper01adres, verkoper01loon);  // resultaat bij juiste invoer
                    Console.WriteLine(time);
                }
                else
                {
                    Console.WriteLine("U heeft helaas een ongeldig wachtwoord gebruikt.");//verkeerde wachtwoord
                }
            }
            if (functieGebruiker == "Verkoper02")//verkoper02
            {
                Console.Write("Wachtwoord invullen: "); //functie als wachtwoord
                wachtwoord = Console.ReadLine();
                if (wachtwoord == "verkoper02")            //controle wachtwoord
                {
                    Console.Write("\n\nWelkom verkoper " + verkoper02naam); // groet bij juiste invoer
                    Console.Write(" , hier zijn uw gegevens: \n\n");
                    Console.WriteLine("\n{0}\n{1}\n{2}", verkoper02naam, verkoper02adres, verkoper02loon);  // resultaat bij juiste invoer
                    Console.WriteLine(time);
                }
                else
                {
                    Console.WriteLine("U heeft helaas een ongeldig wachtwoord gebruikt.");//verkeerde wachtwoord
                }
            }
            if (functieGebruiker == "Verkoper03")//verkoper03
            {
                Console.Write("Wachtwoord invullen: "); //functie als wachtwoord
                wachtwoord = Console.ReadLine();
                if (wachtwoord == "verkoper03")            //controle wachtwoord
                {
                    Console.Write("\n\nWelkom verkoper " + verkoper03naam); // groet bij juiste invoer
                    Console.Write(" , hier zijn uw gegevens: \n\n");
                    Console.WriteLine("\n{0}\n{1}\n{2}", verkoper03naam, verkoper03adres, verkoper03loon);  // resultaat bij juiste invoer
                    Console.WriteLine(time);
                }
                else
                {
                    Console.WriteLine("U heeft helaas een ongeldig wachtwoord gebruikt.");//verkeerde wachtwoord
                }
            }
        }

    }
}

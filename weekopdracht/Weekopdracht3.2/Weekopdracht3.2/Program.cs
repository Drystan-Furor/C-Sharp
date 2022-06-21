using System;
using System.Collections.Generic;

namespace BakkerijSystem
{
    /// <summary>
    /// RCS1102
    /// </summary>
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //data
            const string version = (" versie 3.04.03.04 LP");
            //Version construct: Course Lesson: 3, # Classes: 04, # Menu options 03, # Functions 04 (L)Login, (P)Password,

            //bakery
            const string bakkerijnaam = "Bakkerij Fierce Flour."; // Bakery has employers; 2 Inventory, 3 Sales, 1 Manager
            //login
            
            Login inloggen = new Login();
            inloggen.Credentials();
            
            //login verified
            Console.WriteLine("\n System van " + bakkerijnaam, version);

            //HOOFDMENU
            Console.WriteLine("\n\n HOOFDMENU\n   1. Klanten bestellingen opgeven.\n   2. Nieuwe producten toevoegen.\n   3. Gegevens medewerkers inzien.\n\n");
            Console.Write(" Option 1, 2 of 3\n >"); //3 options
            var keuze = Console.ReadLine();
            var keuze2 = "";
            while (keuze != "1" && keuze != "2" && keuze != "3")
            {
                Console.Write(" > ");
                keuze = Check();
                if (keuze != "1" && keuze != "2" && keuze != "3")
                {
                    Console.Write(" Invoer ongeldig, kies 1, 2 of 3\n > ");
                }
            }
            switch (keuze)
            {
                case "1": //option 1 - customer orders application
                    var klanten = new List<Klantdata>();
                    var volgende = true;

                    while (volgende)
                    {
                        var klant = new Klantdata();
                        klanten.Add(klant);
                        Console.Write("Volgende bestelling? y/n : ");
                        if (Console.ReadLine() == "n")
                        {
                            volgende = false;
                        }
                    }
                    Console.WriteLine("Aantal bestellingen: {0}", Klantdata.totaalklanten);
                    foreach (var klant in klanten)
                    {
                        klant.Display();
                    }
                    break;

                case "3"://Option 3 employee data
                    Console.WriteLine("\n\nPersoneels gegevens\n  1. Adressen Bestand Medewerkers. \n  2. Personeels bestanden.\n");
                    Console.Write(" Keuze 1 of 2\n");

                    while (keuze2 != "1" && keuze2 != "2")
                    {
                        Console.Write(" > ");
                        keuze2 = Check();
                        if (keuze2 != "1" && keuze2 != "2")
                        {
                            Console.Write(" Invoer ongeldig, kies 1 of 2\n> ");
                        }
                    }
                    break;

                case "2": //option 2 products application
                    var producten = new List<Prodapp>();
                    var next = true;

                    while (next)
                    {
                        var product = new Prodapp();
                        producten.Add(product);
                        Console.Write(" Nieuw product toevoegen? 'q' to quit \n > ");
                        if (Console.ReadLine() == "q")
                        {
                            next = false;
                        }
                    }
                    Console.WriteLine(" Aantal producten: {0}", Prodapp.Productentotaal);
                    foreach (var product in producten)
                    {
                        product.Showlist();
                    }
                    break;

                default:
                    Console.Write(" {0} Invoer ongeldig.\n", keuze);
                    break;
            }
            //employee data 1 addresses
            if (keuze2 == "1")
            {
                Personeel adres = new Personeel();
                adres.Adreslijst();
            }

            // employee data 2 personnel records
            if (keuze2 == "2")
            {
                Personeel bestand = new Personeel();
                bestand.Bestanden();
            }
        }

        private static string Check()
        {
            string vraag = Console.ReadLine();
            if (vraag?.Length == 0)

            {
                Console.Write("Invoer ongeldig. probeer het nogmaals:\n > ");
                vraag = Console.ReadLine();
            }
            return vraag;
        }
    }
}
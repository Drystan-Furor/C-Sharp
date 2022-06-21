using System;

namespace BakkerijSystem
{
    internal class Klantdata
    {
        public static int totaalklanten = 0;
        public string Name;
        public string Adres;
        public int Phone;
        public string Bestelling;

        public Klantdata()
        {
            Console.WriteLine("Klant naam: ");
            Console.Write("> ");
            Name = Console.ReadLine();

            Console.WriteLine("Klant Adres: ");
            Console.Write("> ");
            Adres = Console.ReadLine();

            Console.WriteLine("Klant tel.nr.: ");
            Console.Write("> ");
            Phone = int.Parse(Console.ReadLine());

            Console.WriteLine("Gewenste bestelling");
            Console.Write("> ");
            Bestelling = Console.ReadLine();

            Klantdata.totaalklanten++;
        }

        public void Display()
        {
            Console.WriteLine("Klant: {0} \nAdres: {1} \nTelefoon: {2} \nBestelling: {3}", Name, Adres, Phone, Bestelling);
        }
    }
}
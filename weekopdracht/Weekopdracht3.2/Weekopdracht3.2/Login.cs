using System;

namespace BakkerijSystem
{
    internal class Login
    {
        public string username = "";
        public string wachtwoord = "";

        //date & time
        public readonly int mon = DateTime.Today.Month;

        public readonly int da = DateTime.Today.Day;
        public readonly int yer = DateTime.Today.Year;

        public void Credentials()
        {
            Console.WriteLine(da + "." + mon + "." + yer);
            Console.WriteLine(" Vul om te beginnen de gebruikersnaam en wachtwoord in.\n\n");
            Console.WriteLine(" GEBRUIKERSNAAM");
            while (username != "Bakkerij")
            {
                Console.Write(" > ");

                username = Check1();

                if (username != "Bakkerij")
                {
                    Console.WriteLine("Gebruikersnaam onbekend, probeer nogmaals");
                }
            }
            Console.WriteLine(" WACHTWOORD");
            while (wachtwoord != "security")
            {
                Console.Write(" > ");
                wachtwoord = Check1();
                if (wachtwoord != "security")
                {
                    Console.WriteLine("Wachtwoord is niet correct, probeer nogmaals");
                }
            }
        }

        private static string Check1()

        {
            string vrgcr = Console.ReadLine();
            if (vrgcr?.Length == 0)

            {
                Console.Write("Invoer ongeldig. probeer het nogmaals:\n> ");

                vrgcr = Console.ReadLine();
            }

            return vrgcr;
        }
    }
}
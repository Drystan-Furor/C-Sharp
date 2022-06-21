using System;

namespace BakkerijSystem
{
    internal class Prodapp
    {
        public static int Productentotaal = 0;
        public string Prodnaam;
        public float Prodprijs;
        public string ProdIngrd;

        public Prodapp()
        {
            {
                Console.WriteLine(" Wat is de naam van uw product?");
                Console.Write(" > ");
                Prodnaam = (Console.ReadLine());

                Console.WriteLine(" Wat is de prijs van uw product?");
                Console.Write(" > ");
                Prodprijs = (Single.Parse(Console.ReadLine()));
                Prodprijs /= 100;

                Console.WriteLine(" Wat zijn de ingrediënten van uw product?");
                Console.Write(" > ");
                ProdIngrd = (Console.ReadLine());

                Prodapp.Productentotaal++;
            }
        }

        public void Showlist()
        {
            Console.WriteLine(" Product: {0,26:}\n Prijs: {1,28} Euro\n Ingrediënten: {2,21}\n\n", Prodnaam, Prodprijs, ProdIngrd);
        }
    }
}
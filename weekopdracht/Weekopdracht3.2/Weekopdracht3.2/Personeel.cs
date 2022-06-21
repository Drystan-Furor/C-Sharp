using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BakkerijSystem
{
    public static class TableParser
    {
        public static string ToStringTable<T>(
          this IEnumerable<T> values,
          string[] columnHeaders,
          params Func<T, object>[] valueSelectors)
        {
            return ToStringTable(values.ToArray(), columnHeaders, valueSelectors);
        }

        public static string ToStringTable<T>(
          this T[] values,
          string[] columnHeaders,
          params Func<T, object>[] valueSelectors)
        {
            Debug.Assert(columnHeaders.Length == valueSelectors.Length);

            var arrValues = new string[values.Length + 1, valueSelectors.Length];

            // Fill headers
            for (int colIndex = 0; colIndex < arrValues.GetLength(1); colIndex++)
            {
                arrValues[0, colIndex] = columnHeaders[colIndex];
            }

            // Fill table rows
            for (int rowIndex = 1; rowIndex < arrValues.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < arrValues.GetLength(1); colIndex++)
                {
                    arrValues[rowIndex, colIndex] = valueSelectors[colIndex]
                      .Invoke(values[rowIndex - 1]).ToString();
                }
            }

            return ToStringTable(arrValues);
        }

        public static string ToStringTable(this string[,] arrValues)
        {
            int[] maxColumnsWidth = GetMaxColumnsWidth(arrValues);
            var headerSpliter = new string('-', maxColumnsWidth.Sum(i => i + 3) - 1);

            var sb = new StringBuilder();
            for (int rowIndex = 0; rowIndex < arrValues.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < arrValues.GetLength(1); colIndex++)
                {
                    // Print cell
                    string cell = arrValues[rowIndex, colIndex];
                    cell = cell.PadRight(maxColumnsWidth[colIndex]);
                    sb.Append(" | ");
                    sb.Append(cell);
                }

                // Print end of line
                sb.Append(" | ");
                sb.AppendLine();

                // Print splitter
                if (rowIndex == 0)
                {
                    sb.AppendFormat(" |{0}| ", headerSpliter);
                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }

        private static int[] GetMaxColumnsWidth(string[,] arrValues)
        {
            var maxColumnsWidth = new int[arrValues.GetLength(1)];
            for (int colIndex = 0; colIndex < arrValues.GetLength(1); colIndex++)
            {
                for (int rowIndex = 0; rowIndex < arrValues.GetLength(0); rowIndex++)
                {
                    int newLength = arrValues[rowIndex, colIndex].Length;
                    int oldLength = maxColumnsWidth[colIndex];

                    if (newLength > oldLength)
                    {
                        maxColumnsWidth[colIndex] = newLength;
                    }
                }
            }

            return maxColumnsWidth;
        }
    }
    internal class Personeel
    {
        //Employee Data
        //manager stats
        public string managernaam;
        public string manageradres;
        public string managerloon;
        public string managerdienst;
        public string managerfunctie;

        //inventory stats
        public string inkoper01naam;
        public string inkoper01adres;
        public string inkoper01loon;
        public string inkoper01dienst;
        public string inkoper01functie;

        public string inkoper02naam;
        public string inkoper02adres;
        public string inkoper02loon;
        public string inkoper02dienst;
        public string inkoper02functie;

        //sales stats
        public string verkoper01naam;
        public string verkoper01adres;
        public string verkoper01loon;
        public string verkoper01dienst;
        public string verkoper01functie;

        public string verkoper02naam;
        public string verkoper02adres;
        public string verkoper02loon;
        public string verkoper02dienst;
        public string verkoper02functie;

        public string verkoper03naam;
        public string verkoper03adres;
        public string verkoper03loon;
        public string verkoper03dienst;
        public string verkoper03functie;

        public Personeel()
        {   //manager stats
            managernaam = "Drystan Furor";
            manageradres = "Himdall Hordplein 184";
            managerloon = "Salaris 6373,- ";
            managerdienst = "20 + jaar ervaring";
            managerfunctie = "Kaderlid: Senior Manager";

            //inventory stats
            inkoper01naam = "Parthenas Virgilius Maro";
            inkoper01adres = "Gan Coileáin weg 162";
            inkoper01loon = "Salaris 5769,23 ";
            inkoper01dienst = "10+ jaar ervaring";
            inkoper01functie = "tactisch inkoper";

            inkoper02naam = "Celaralindë Tarnir";
            inkoper02adres = "Ronodrilstraat 110";
            inkoper02loon = "Salaris 3269,23 ";
            inkoper02dienst = "3+ jaar ervaring";
            inkoper02functie = "operationeel inkoper";

            //sales stats
            verkoper01naam = "Malthael Chalad'ar";
            verkoper01adres = "Angiris Raadsplein 21";
            verkoper01loon = "Salaris 2.863,93 ";
            verkoper01dienst = "16 jaar ervaring";
            verkoper01functie = "Verkoopmedewerker";

            verkoper02naam = "Naam: Jester van Falconia";
            verkoper02adres = "Adres: Steenbaai 34";
            verkoper02loon = "Salaris 2.263,93 ";
            verkoper02dienst = "14 jaar ervaring";
            verkoper02functie = "Verkoopmedewerker";

            verkoper03naam = "Elmira Elbage";
            verkoper03adres = "Belkora Boslaan 168";
            verkoper03loon = "Salaris 1.863,93 ";
            verkoper03dienst = "1 jaar ervaring";
            verkoper03functie = "Verkoopmedewerker";
        }

        public void Adreslijst()
        {
            {
                Tuple<int, string, string>[] employers =
                new[]
                {
             Tuple.Create(1, managernaam, manageradres),
             Tuple.Create(2, inkoper01naam, inkoper01adres),
             Tuple.Create(3, inkoper02naam, inkoper02adres),
             Tuple.Create(4, verkoper01naam, verkoper01adres),
             Tuple.Create(5, verkoper02naam, verkoper02adres),
             Tuple.Create(6, verkoper03naam, verkoper03adres),
                };

                Console.WriteLine(employers.ToStringTable(
                  new[] { "Id", "Name", "Address" },
                  a => a.Item1, a => a.Item2, a => a.Item3));
            }
        }

        public void Bestanden()
        {
            var time = DateTime.Now;
            var personeelfunctie = "";
            Console.WriteLine("\n Manager \n Verkoper01 \n Verkoper02 \n Verkoper03 \n Inkoper01 \n Inkoper02");
            Console.WriteLine("\n\nWelke werknemer gegevens wilt u inzien? \n(Kies uit bovenstaande, Hoofdlettergevoelig)\n"); //functie vaststellen
            while (personeelfunctie != "Manager" && personeelfunctie != "Verkoper01" && personeelfunctie != "Verkoper02" && personeelfunctie != "Verkoper03" && personeelfunctie != "Inkoper01" && personeelfunctie != "Inkoper02")
            {
                Console.Write(" > ");
                personeelfunctie = Check2();
                if (personeelfunctie != "Manager" && personeelfunctie != "Verkoper01" && personeelfunctie != "Verkoper02" && personeelfunctie != "Verkoper03" && personeelfunctie != "Inkoper01" && personeelfunctie != "Inkoper02")
                    Console.Write("Invoer ongeldig. probeer het nogmaals:\n> ");
            }
            Console.WriteLine();
            switch (personeelfunctie)

            {
                //manager
                case "Manager":  //manager
                                 //Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", managernaam, manageradres, managerloon, time);
                    {
                        Tuple<string, string>[] employer1 =
                        new[]
                        {
                         Tuple.Create("Naam", managernaam),
                         Tuple.Create("Adres",manageradres),
                         Tuple.Create("Functie", managerfunctie),
                         Tuple.Create("Dienstverband", managerdienst),
                         Tuple.Create("Loon", managerloon),
                        };
                        Console.WriteLine(employer1.ToStringTable(
                          new[] { "Gegevens", "Werknemer" },
                          a => a.Item1, a => a.Item2 ));
                    }
                    Console.WriteLine(time);
                    break;

                //inventory
                case "Inkoper01"://inkoper01
                    {
                        Tuple<string, string>[] employer1 =
                        new[]
                        {
                         Tuple.Create("Naam", inkoper01naam),
                         Tuple.Create("Adres",inkoper01adres),
                         Tuple.Create("Functie", inkoper01functie),
                         Tuple.Create("Dienstverband", inkoper01dienst),
                         Tuple.Create("Loon", inkoper01loon),
                        };
                        Console.WriteLine(employer1.ToStringTable(
                          new[] { "Gegevens", "Werknemer" },
                          a => a.Item1, a => a.Item2));
                    }
                    Console.WriteLine(time);
                    break;

                case "Inkoper02": //inkoper02
                    {
                        Tuple<string, string>[] employer1 =
                        new[]
                        {
                         Tuple.Create("Naam", inkoper02naam),
                         Tuple.Create("Adres",inkoper02adres),
                         Tuple.Create("Functie", inkoper02functie),
                         Tuple.Create("Dienstverband", inkoper02dienst),
                         Tuple.Create("Loon", inkoper02loon),
                        };
                        Console.WriteLine(employer1.ToStringTable(
                          new[] { "Gegevens", "Werknemer" },
                          a => a.Item1, a => a.Item2));
                    }
                    Console.WriteLine(time);
                    break;

                //sales
                case "Verkoper01": //verkoper01
                    {
                        Tuple<string, string>[] employer1 =
                        new[]
                        {
                         Tuple.Create("Naam", verkoper01naam),
                         Tuple.Create("Adres",verkoper01adres),
                         Tuple.Create("Functie", verkoper01functie),
                         Tuple.Create("Dienstverband", verkoper01dienst),
                         Tuple.Create("Loon", verkoper01loon),
                        };
                        Console.WriteLine(employer1.ToStringTable(
                          new[] { "Gegevens", "Werknemer" },
                          a => a.Item1, a => a.Item2));
                    }
                    Console.WriteLine(time);
                    break;

                case "Verkoper02": //verkoper02
                    {
                        Tuple<string, string>[] employer1 =
                        new[]
                        {
                         Tuple.Create("Naam", verkoper02naam),
                         Tuple.Create("Adres",verkoper02adres),
                         Tuple.Create("Functie", verkoper02functie),
                         Tuple.Create("Dienstverband", verkoper02dienst),
                         Tuple.Create("Loon", verkoper02loon),
                        };
                        Console.WriteLine(employer1.ToStringTable(
                          new[] { "Gegevens", "Werknemer" },
                          a => a.Item1, a => a.Item2));
                    }
                    Console.WriteLine(time);
                    break;

                case "Verkoper03": //verkoper03
                    {
                        Tuple<string, string>[] employer1 =
                        new[]
                        {
                         Tuple.Create("Naam", verkoper03naam),
                         Tuple.Create("Adres",verkoper03adres),
                         Tuple.Create("Functie", verkoper03functie),
                         Tuple.Create("Dienstverband", verkoper03dienst),
                         Tuple.Create("Loon", verkoper03loon),
                        };
                        Console.WriteLine(employer1.ToStringTable(
                          new[] { "Gegevens", "Werknemer" },
                          a => a.Item1, a => a.Item2));
                    }
                    Console.WriteLine(time);
                    break;

                default:
                    Console.Write("Invoer ongeldig.\n");
                    break;
            }
        }

        private static string Check2()

        {
            string vrg = Console.ReadLine();
            if (vrg?.Length == 0)

            {
                Console.Write("Invoer ongeldig. probeer het nogmaals:\n> ");

                vrg = Console.ReadLine();
            }

            return vrg;
        }
    }
}
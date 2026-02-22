using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;

namespace NaidisTar1
{
    public class EsimineOsaFunktsionid
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n---- MENÜÜ ----");
                Console.WriteLine("1 - Juhu");
                Console.WriteLine("2 - Naabrid");
                Console.WriteLine("3 - Põrand");
                Console.WriteLine("4 - Allahindlus");
                Console.WriteLine("5 - Temperatuur");
                Console.WriteLine("6 - Pikkus");
                Console.WriteLine("7 - Pikkus M/N");
                Console.WriteLine("8 - Pood");
                Console.WriteLine("0 - Välju");
                Console.Write("Valik: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1": Juhu(); break;
                    case "2": Naabrid(); break;
                    case "3": Porand(); break;
                    case "4": Allahindlus(); break;
                    case "5": Temperatuur(); break;
                    case "6": Pikkus(); break;
                    case "7": PikkusMN(); break;
                    case "8": Pood(); break;
                    case "0": return;
                    default: Console.WriteLine("Vale valik!"); break;
                }
            }
        }

        public static void Juhu()
        {
            Console.WriteLine("Palun sisesta nimi");
            string nimi = Console.ReadLine();

            if (nimi != "Juhu")
            {
                Console.WriteLine("Ma olen hõivatud");
                return;
            }

            Console.WriteLine("Lähme kinnosse");

            try
            {
                Console.WriteLine("Palun sisesta vanus");
                int vanus = Convert.ToInt32(Console.ReadLine());

                if (vanus < 0 || vanus > 100)
                    Console.WriteLine("Viga: vanus peab olema vahemikus 0-100");
                else if (vanus < 6)
                    Console.WriteLine("Tasuta");
                else if (vanus <= 14)
                    Console.WriteLine("Lapse pilet");
                else if (vanus <= 65)
                    Console.WriteLine("Tavaline pilet");
                else
                    Console.WriteLine("Pensionäri pilet");
            }
            catch
            {
                Console.WriteLine("Viga andmetega!");
            }
        }

        public static void Naabrid()
        {
            Console.WriteLine("Palun sisesta esimese õpilase nimi:");
            string nimi1 = Console.ReadLine();

            Console.WriteLine("Palun sisesta teise õpilase nimi:");
            string nimi2 = Console.ReadLine();

            Console.WriteLine($"Tere, {nimi1} ja {nimi2}! Täna olete te pinginaabrid.");
        }

        public static void Porand()
        {
            try
            {
                Console.WriteLine("Sisesta toa pikkus:");
                int pikkus = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sisesta toa laius:");
                int laius = Convert.ToInt32(Console.ReadLine());

                int pindala = pikkus * laius;
                Console.WriteLine($"Põranda pindala: {pindala} m²");

                Console.WriteLine("Kas soovid teha remonti? (jah/ei):");
                string vastus = Console.ReadLine().ToLower();

                if (vastus == "jah" || vastus == "yes")
                {
                    Console.WriteLine("Sisesta 1 m² hind:");
                    int hind = Convert.ToInt32(Console.ReadLine());

                    int kogumaksumus = pindala * hind;
                    Console.WriteLine($"Põranda vahetamise maksumus: {kogumaksumus} €");
                }
                else
                {
                    Console.WriteLine("Okei, remonti ei tee.");
                }
            }
            catch
            {
                Console.WriteLine("Viga sisestamisel!");
            }
        }

        public static void Allahindlus()
        {
            try
            {
                Console.WriteLine("Sisesta hind pärast 30% allahindlust:");
                float allahinnaga = Convert.ToSingle(Console.ReadLine());

                float algne = allahinnaga / 0.7f;

                Console.WriteLine($"Algne hind oli: {algne:F2} €");
                Console.WriteLine($"Allahindlus oli: {(algne - allahinnaga):F2} €");
            }
            catch
            {
                Console.WriteLine("Viga sisestamisel!");
            }
        }

        public static void Temperatuur()
        {
            try
            {
                Console.WriteLine("Sisesta temperatuur:");
                int temperatuur = Convert.ToInt32(Console.ReadLine());

                if (temperatuur > 18)
                    Console.WriteLine($"Temperatuur {temperatuur}°C on kõrgem kui soovitatud 18°C.");
                else if (temperatuur == 18)
                    Console.WriteLine("Temperatuur on täpselt soovitatud tase.");
                else
                    Console.WriteLine($"Temperatuur {temperatuur}°C on madalam kui soovitatud 18°C.");
            }
            catch
            {
                Console.WriteLine("Viga sisestamisel!");
            }
        }

        public static void Pikkus()
        {
            try
            {
                Console.WriteLine("Sisesta oma pikkus (cm):");
                int pikkus = Convert.ToInt32(Console.ReadLine());

                if (pikkus < 160)
                    Console.WriteLine("Sa oled lühike.");
                else if (pikkus <= 180)
                    Console.WriteLine("Sa oled keskmise pikkusega.");
                else
                    Console.WriteLine("Sa oled pikk.");
            }
            catch
            {
                Console.WriteLine("Viga sisestamisel!");
            }
        }

        public static void PikkusMN()
        {
            try
            {
                Console.WriteLine("Sisesta oma sugu (M/N):");
                string sugu = Console.ReadLine().ToUpper();

                Console.WriteLine("Sisesta oma pikkus (cm):");
                int pikkus = Convert.ToInt32(Console.ReadLine());

                if (sugu == "M")
                {
                    if (pikkus < 170)
                        Console.WriteLine("Mees - lühike");
                    else if (pikkus <= 185)
                        Console.WriteLine("Mees - keskmine");
                    else
                        Console.WriteLine("Mees - pikk");
                }
                else if (sugu == "N")
                {
                    if (pikkus < 160)
                        Console.WriteLine("Naine - lühike");
                    else if (pikkus <= 175)
                        Console.WriteLine("Naine - keskmine");
                    else
                        Console.WriteLine("Naine - pikk");
                }
                else
                {
                    Console.WriteLine("Viga: sisesta M või N!");
                }
            }
            catch
            {
                Console.WriteLine("Viga sisestamisel!");
            }
        }

        public static void Pood()
        {
            float kogusumma = 0;

            Console.WriteLine("Kas soovid osta piima? (jah/ei):");
            if (Console.ReadLine().ToLower() == "jah")
            {
                kogusumma += 1.50f;
                Console.WriteLine("Piim lisatud: 1.50 €");
            }

            Console.WriteLine("Kas soovid osta saia? (jah/ei):");
            if (Console.ReadLine().ToLower() == "jah")
            {
                kogusumma += 0.80f;
                Console.WriteLine("Sai lisatud: 0.80 €");
            }

            Console.WriteLine("Kas soovid osta leiba? (jah/ei):");
            if (Console.ReadLine().ToLower() == "jah")
            {
                kogusumma += 1.20f;
                Console.WriteLine("Leib lisatud: 1.20 €");
            }

            Console.WriteLine($"\nKokku maksta: {kogusumma:F2} €");
        }
    }
}










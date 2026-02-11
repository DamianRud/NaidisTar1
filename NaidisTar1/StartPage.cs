using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;

namespace NaidisTar1
{
    public class StartPage
    {
        public static void Main(string[]args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("1.Osa andmetüübid,Alamfunktsionid/meetodid");
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //string text = "Tere Tulemast C-i maailma";
            //Console.WriteLine();
            //Console.WriteLine("Oli loodud muutuja tekst, mis võrdub", text);
            //Console.WriteLine();
            //Console.Write("Mis on sinu nimi:");
            //string nimi = Console.ReadLine();
            //Console.WriteLine("kui vana sa oled!:");
            //try
            //{
            //    int vanus = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Tere{nimi}.Sa oled {vanus} aasta vana");
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e);
            //}
            //Console.WriteLine("Arv1:");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("Arv2:");
            //float b = float.Parse(Console.ReadLine());
            //float vastus = NaidisFunktsionid.Summa(a, b);
            //Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");

            //Random rnd = new Random();
            //int juhustlik_arv = rnd.Next(-5, 25);
            //Console.WriteLine(NaidisFunktsionid.Kuu_nimetus(juhustlik_arv));
            //juhustlik_arv = rnd.Next(-5, 25);
            //tekst = NaidisFunktsionid.Kuu_nimetus(juhustlik_arv);
            //Console.WriteLine(tekst);



        }
        class Isik
        {
            public string Nimi;
            public int Vanus;

            public void Tervita()
            {
                Console.WriteLine("Tere, minu nimi on " + Nimi);
            }
        }

        static void Main()
        {
            List<Isik> inimesed = new List<Isik>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                Isik uusIsik = new Isik();
                uusIsik.Nimi = nimi;
                uusIsik.Vanus = vanus;

                inimesed.Add(uusIsik);
            }

            Console.WriteLine("\nKõik inimesed tervitavad:\n");

            foreach (Isik isik in inimesed)
            {
                isik.Tervita();
            }
        }

    }
}

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
            Console.WriteLine("1.Osa andmetüübid,Alamfunktsionid/meetodid");
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.ForegroundColor = ConsoleColor.Blue;
            string text = "Tere Tulemast C-i maailma";
            Console.WriteLine();
            Console.WriteLine("Oli loodud muutuja tekst, mis võrdub", text);
            Console.WriteLine();
            Console.Write("Mis on sinu nimi:");
            string nimi = Console.ReadLine();
            Console.WriteLine("kui vana sa oled!:");
            try
            { 
                int vanus = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tere{nimi}.Sa oled {vanus} aasta vana");
            }
            catch (Exception e)
            { 
              
                    Console.WriteLine(e);
            }
            Console.WriteLine("Arv1:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Arv2:");
            float b = float.Parse(Console.ReadLine());
            float vastus = NaidisFunktsionid.Summa(a, b);
            Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");

            




        }

    }
}

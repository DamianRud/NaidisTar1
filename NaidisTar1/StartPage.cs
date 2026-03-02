using System;
using System.Text;

namespace NaidisTar1
{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1 - ArvamisMang");
                Console.WriteLine("2 - LeiaSuurim");
                Console.WriteLine("3 - LoendaArvud");
                Console.WriteLine("4 - GenereeriJaKeskmine");
                Console.WriteLine("5 - ListiAnaluus");
                Console.WriteLine("6 - ArvudeRuudud");
                Console.WriteLine("7 - Elevant");
                Console.WriteLine("8 - OpilasteMang");
                Console.WriteLine("0 - Exit");
                Console.Write("Vali number: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        _3OsaFunktsionid.ArvamisMang();
                        break;
                    case "2":
                        _3OsaFunktsionid.LeiaSuurim();
                        break;
                    case "3":
                        _3OsaFunktsionid.LoendaArvud();
                        break;
                    case "4":
                        _3OsaFunktsionid.GenereeriJaKeskmine();
                        break;
                    case "5":
                        _3OsaFunktsionid.ListiAnaluus();
                        break;
                    case "6":
                        _3OsaFunktsionid.ArvudeRuudud();
                        break;
                    case "7":
                        _3OsaFunktsionid.Elevant();
                        break;
                    case "8":
                        _3OsaFunktsionid.OpilasteMang();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Vale valik!");
                        break;
                }




                //List<Inimene> Inimesed = new List<Inimene>();

                //for (int i = 0; i < 5; i++)
                //{
                //    Inimene inimene1 = new Inimene("Sisesta Nimi", 100);
                //}

                //Console.OutputEncoding = Encoding.UTF8;

                //Console.WriteLine("Sisessta Nimi");
                //string nimi = Console.ReadLine();

                //Console.WriteLine("Sisesta Vanus");
                //int vanus = int.Parse(Console.ReadLine());

                //Inimene Inimene2 = new Inimene(nimi, vanus);
                //Inimesed.Add(Inimene2);
            }
        }
    }
}















using NaidisTar1;
using System;
using System.Text;

namespace NaidisTar1
{
    internal class Osa1
    {
        public static void Main(string[] args)
        {
            bool lahku = false;

            while (!lahku)
            {
                Console.Clear();
                Console.WriteLine("=== Tere tulemast! ===");
                Console.WriteLine("1. Tervita kasutajat");
                Console.WriteLine("2. Korruta kaks arvu");
                Console.WriteLine("3. Välju");
                Console.Write("Vali valik: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                       

                       Console.Write("Sisesta oma nimi: ");
                        string nimi = Console.ReadLine();
                        Console.WriteLine("Tere, " + nimi + "!");
                        Console.WriteLine("Vajuta suvalist klahvi tagasi pöördumiseks menüüsse...");
                        Console.ReadKey();
                        break;

                    case "2":

                        Console.Write("Sisesta esimene arv: ");
                        int arv1 = int.Parse(Console.ReadLine());
                        Console.Write("Sisesta teine arv: ");
                        int arv2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Arvude {arv1} ja {arv2} korrutis on {arv1 * arv2}");
                        Console.WriteLine("Vajuta suvalist klahvi tagasi pöördumiseks menüüsse...");
                        Console.ReadKey();
                        break;

                    case "3":
                    lahku = true;
                    break;

                    default:
                    Console.WriteLine("Vale valik. Vajuta suvalist klahvi tagasi pöördumiseks...");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}

















//        }
//        public static int[,] GenereeriKorrustustabel(int ridadearv,int veerguadeArv)
//        {
//            int[,] tabel = new int[ridadearv, veerguadeArv];
//            for(int i=0;i<ridadearv,i++)
//            {
//                for(int j=0;j<veerguadeArv;j++)
//                {
//                    tabel[i, j] = (i * 1) * (j * 1);
//                    Console.WriteLine(tabel[i,j].ToString().PadLeft(5));
//                    {
//                        Console.WriteLine();
//                        {
//                            return tabel;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}


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



//        }
//        class Isik
//        {
//            public string Nimi;
//            public int Vanus;

//            public void Tervita()
//            {
//                Console.WriteLine("Tere, minu nimi on " + Nimi);
//            }
//        }

//        static void Main()
//        {
//            List<Isik> inimesed = new List<Isik>();

//            for (int i = 0; i < 3; i++)
//            {
//                Console.Write("Sisesta nimi: ");
//                string nimi = Console.ReadLine();

//                Console.Write("Sisesta vanus: ");
//                int vanus = int.Parse(Console.ReadLine());

//                Isik uusIsik = new Isik();
//                uusIsik.Nimi = nimi;
//                uusIsik.Vanus = vanus;

//                inimesed.Add(uusIsik);
//            }

//            Console.WriteLine("\nKõik inimesed tervitavad:\n");

//            foreach (Isik isik in inimesed)
//            {
//                isik.Tervita();
//            }
//        }

//    }
//}
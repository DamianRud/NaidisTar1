//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace NaidisTar1
//{
//    public class _3OsaFunktsionid
//    {
//        static void Main(string[] args)
//        {
//            ArvamisMang();
//            LeiaSuurim();
//            LoendaArvud();
//            GenereeriJaKeskmine();
//            ListiAnaluus();
//            ArvudeRuudud();
//            Elevant();
//            OpilasteMang();
//        }

//        static void ArvamisMang()
//        {
//            bool mangiUuesti = true;
//            while (mangiUuesti)
//            {
//                ArvaArv();
//                Console.WriteLine("Kas soovite uuesti mängida? (jah/ei)");
//                string vastus = Console.ReadLine().ToLower();
//                mangiUuesti = (vastus == "jah");
//            }
//            Console.WriteLine("Aitäh mängimast!");
//        }

//        static void ArvaArv()
//        {
//            Random random = new Random();
//            int salajaneArv = random.Next(1, 101);
//            int katsed = 5;
//            Console.WriteLine("Ma mõtlesin arvu vahemikus 1 kuni 100. Teil on 5 katset!");
//            for (int i = 1; i <= katsed; i++)
//            {
//                Console.Write($"Katse {i}: Sisestage number: ");
//                int pakkumine;
//                if (!int.TryParse(Console.ReadLine(), out pakkumine))
//                {
//                    Console.WriteLine("Palun sisestage korrektne number!");
//                    i--;
//                    continue;
//                }
//                if (pakkumine > salajaneArv)
//                {
//                    Console.WriteLine("Liiga suur number!");
//                }
//                else if (pakkumine < salajaneArv)
//                {
//                    Console.WriteLine("Liiga väike number!");
//                }
//                else
//                {
//                    Console.WriteLine("Õige number! Te võitsite!");
//                    return;
//                }
//            }
//            Console.WriteLine($"Te kaotasite! Salajane number oli: {salajaneArv}");
//        }

//        static void LeiaSuurim()
//        {
//            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
//            int suurim = numbrid[0];
//            int indeks = 0;
//            for (int i = 1; i < numbrid.Length; i++)
//            {
//                if (numbrid[i] > suurim)
//                {
//                    suurim = numbrid[i];
//                    indeks = i;
//                }
//            }
//            Console.WriteLine($"Suurim arv on {suurim} ja selle indeks on {indeks}.");
//        }

//        static void LoendaArvud()
//        {
//            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
//            int positiivsed = 0;
//            int negatiivsed = 0;
//            int nullid = 0;
//            foreach (int arv in arvud)
//            {
//                if (arv > 0) positiivsed++;
//                else if (arv < 0) negatiivsed++;
//                else nullid++;
//            }
//            Console.WriteLine($"Positiivseid arve: {positiivsed}");
//            Console.WriteLine($"Negatiivseid arve: {negatiivsed}");
//            Console.WriteLine($"Nulle: {nullid}");
//        }

//        static void GenereeriJaKeskmine()
//        {
//            Random rnd = new Random();
//            int[] arvud = new int[15];
//            for (int i = 0; i < arvud.Length; i++)
//            {
//                arvud[i] = rnd.Next(1, 101);
//            }
//            Console.WriteLine("Genereeritud arvud:");
//            foreach (int arv in arvud)
//            {
//                Console.Write(arv + " ");
//            }
//            Console.WriteLine();
//            int summa = 0;
//            foreach (int arv in arvud)
//            {
//                summa += arv;
//            }
//            double keskmine = (double)summa / arvud.Length;
//            Console.WriteLine($"\nKeskmine väärtus: {keskmine:F2}");
//            Console.WriteLine("\nArvud, mis on suuremad kui keskmine:");
//            foreach (int arv in arvud)
//            {
//                if (arv > keskmine)
//                    Console.Write(arv + " ");
//            }
//            Console.WriteLine();
//            Console.WriteLine("\nArvude väljastamine kuni kohtame arvu < 10:");
//            int index = 0;
//            do
//            {
//                Console.Write(arvud[index] + " ");
//                index++;
//            } while (index < arvud.Length && arvud[index - 1] >= 10);
//            Console.WriteLine("\nProgramm lõpetatud.");
//        }

//        static void ListiAnaluus()
//        {
//            Random rnd = new Random();
//            List<int> arvud = new List<int>();
//            for (int i = 0; i < 20; i++)
//            {
//                arvud.Add(rnd.Next(1, 101));
//            }
//            Console.WriteLine("Genereeritud arvud:");
//            foreach (int arv in arvud)
//            {
//                Console.Write(arv + " ");
//            }
//            Console.WriteLine();
//            int paarisSumma = 0;
//            for (int i = 0; i < arvud.Count; i++)
//            {
//                if (arvud[i] % 2 == 0)
//                    paarisSumma += arvud[i];
//            }
//            Console.WriteLine($"\nPaarisarvude kogusumma: {paarisSumma}");
//            int paarituSumma = 0;
//            int paarituLoendur = 0;
//            foreach (int arv in arvud)
//            {
//                if (arv % 2 != 0)
//                {
//                    paarituSumma += arv;
//                    paarituLoendur++;
//                }
//            }
//            double paarituKeskmine = paarituLoendur > 0 ? (double)paarituSumma / paarituLoendur : 0;
//            Console.WriteLine($"Paaritute arvude keskmine: {paarituKeskmine:F2}");
//            int index = 0;
//            int suuremadKui50 = 0;
//            while (index < arvud.Count)
//            {
//                if (arvud[index] > 50)
//                    suuremadKui50++;
//                index++;
//            }
//            Console.WriteLine($"Arve, mis on suuremad kui 50: {suuremadKui50}");
//        }

//        static void ArvudeRuudud()
//        {
//            int[] arvud = { 2, 4, 6, 8, 10, 12 };
//            Console.WriteLine("Arvude ruudud:");
//            for (int i = 0; i < arvud.Length; i++)
//            {
//                int ruut = arvud[i] * arvud[i];
//                Console.WriteLine($"{arvud[i]}^2 = {ruut}");
//            }
//            Console.WriteLine("\nArvude kahekordsed väärtused:");
//            foreach (int arv in arvud)
//            {
//                Console.WriteLine($"{arv} x 2 = {arv * 2}");
//            }
//            int index = 0;
//            int jagubKolmega = 0;
//            while (index < arvud.Length)
//            {
//                if (arvud[index] % 3 == 0)
//                    jagubKolmega++;
//                index++;
//            }
//            Console.WriteLine($"\nArvud, mis jaguvad 3-ga: {jagubKolmega}");
//        }

//        static void Elevant()
//        {
//            string märksõna = "elevant";
//            string fraas = "Osta elevant ära!";
//            List<string> sisendid = KuniMärksõnani(märksõna, fraas);
//            Console.WriteLine("\nKasutaja sisestused:");
//            foreach (string s in sisendid)
//            {
//                Console.WriteLine(s);
//            }
//        }

//        static List<string> KuniMärksõnani(string märksõna, string fraas)
//        {
//            List<string> sisestused = new List<string>();
//            string sisend;
//            do
//            {
//                Console.WriteLine(fraas);
//                sisend = Console.ReadLine();
//                sisestused.Add(sisend);
//            } while (sisend != märksõna);
//            return sisestused;
//        }

//        static void OpilasteMang()
//        {
//            string[] nimed = new string[6];
//            Õpilastega_mängimine(nimed);
//        }

//        public static void Õpilastega_mängimine(string[] nimed)
//        {
//            Console.WriteLine("Uus nimi:");
//            string nimi1 = Console.ReadLine();
//            if (nimed.Length > 2) nimed[2] = nimi1;
//            if (nimed.Length > 5) nimed[5] = "Mati";
//            int i = 0;
//            while (i < nimed.Length)
//            {
//                if (!string.IsNullOrEmpty(nimed[i]) && nimed[i].StartsWith("A"))
//                {
//                    Console.WriteLine("Tere " + nimed[i]);
//                }
//                i++;
//            }
//            for (int j = 0; j < nimed.Length; j++)
//            {
//                Console.WriteLine($"Indeks {j}: {nimed[j]}");
//            }
//            foreach (string nimi in nimed)
//            {
//                if (!string.IsNullOrEmpty(nimi))
//                    Console.WriteLine(nimi.ToLower());
//            }
//            i = 0;
//            do
//            {
//                if (nimed[i] == "Mati")
//                {
//                    Console.WriteLine("Leidsin Mati");
//                    break;
//                }
//                Console.WriteLine($"Tere {nimed[i]}");
//                i++;
//            }
//            while (i < nimed.Length);
//        }
//    }
//}


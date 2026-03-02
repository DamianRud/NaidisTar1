using System;

namespace NaidisTar1
{
    public class NaidisFunktsioonid
    {
        
        public static float Summa(float arv1, float arv2)
        {
            return arv1 + arv2;
        }

        
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = kuu_nr switch
            {
                1 => "Jaanuar",
                2 => "Veebruar",
                3 => "Märts",
                4 => "Aprill",
                5 => "Mai",
                6 => "Juuni",
                7 => "Juuli",
                8 => "August",
                9 => "September",
                10 => "Oktoober",
                11 => "November",
                12 => "Detsember",
                _ => "???"
            };
            return kuu;
        }

        
        public static string Hooaeg(int kuu_nr)
        {
            if (kuu_nr == 12 || kuu_nr == 1 || kuu_nr == 2) return "Talv";
            if (kuu_nr >= 3 && kuu_nr <= 5) return "Kevad";
            if (kuu_nr >= 6 && kuu_nr <= 8) return "Suvi";
            if (kuu_nr >= 9 && kuu_nr <= 11) return "Sügis";
            return "???";
        }

        
        public static int[] Täida_massiiv(int[] arvud)
        {
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.Write($"Sisesta {i + 1}. arv: ");
                try
                {
                    arvud[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Viga: " + e.Message);
                    i--; 
                }
            }
            return arvud;
        }

        
        public static double[] Täida_massiiv_double(double[] arvud)
        {
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.Write($"Sisesta {i + 1}. arv: ");
                try
                {
                    arvud[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Viga: " + e.Message);
                    i--; 
                }
            }
            return arvud;
        }

        
        public static void Massiivide_kuvamine(int[] arvud)
        {
            Console.WriteLine("Foreach abil:");
            foreach (int arv in arvud)
                Console.WriteLine(arv);

            Console.WriteLine("For abil: esimene->viimane");
            for (int i = 0; i < arvud.Length; i++)
                Console.WriteLine(arvud[i]);

            Console.WriteLine("For abil: viimane->esimene");
            for (int i = arvud.Length - 1; i >= 0; i--)
                Console.WriteLine(arvud[i]);
        }

        
        public static void Muuda_element_massiivis(int[] arvud)
        {
            Console.Write("Kuhu (positsioon): ");
            int positsioon = int.Parse(Console.ReadLine());
            Console.Write("Milliseks: ");
            int uus_arv = int.Parse(Console.ReadLine());
            if (positsioon >= 1 && positsioon <= arvud.Length)
            {
                arvud[positsioon - 1] = uus_arv;
                Console.WriteLine("Uuendatud massiiv:");
                Massiivide_kuvamine(arvud);
            }
            else
            {
                Console.WriteLine("Vale positsioon!");
            }
        }
    }
}





















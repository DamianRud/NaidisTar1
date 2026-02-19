//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace NaidisTar1
//{
//    public class _3OsaFunktsionid


//    {


//        static void Main(string[] args)
//        {

//            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };


//            int max = numbrid[0];
//            int maxIndex = 0;


//            for (int i = 1; i < numbrid.Length; i++)
//            {
//                if (numbrid[i] > max)
//                {
//                    max = numbrid[i];
//                    maxIndex = i;
//                }
//            }


//            Console.WriteLine("Suurim arv: " + max);
//            Console.WriteLine("Suurima arvu indeks: " + maxIndex);
//        }
//    }
//}


using System;

class Program
{
    public static void Õpilastega_mängimine(string[] nimed)
    {
        Console.WriteLine("Uus nimi:");
        string nimi1 = Console.ReadLine();

        
        if (nimed.Length > 2) nimed[2] = nimi1;
        if (nimed.Length > 5) nimed[5] = "Mati";

        
        int i = 0;
        while (i < nimed.Length)
        {
            if (!string.IsNullOrEmpty(nimed[i]) && nimed[i].StartsWith("A"))
            {
                Console.WriteLine("Tere " + nimed[i]);
            }
            i++;
        }

        
        for (int j = 0; j < nimed.Length; j++)
        {
            Console.WriteLine($"Indeks {j}: {nimed[j]}");
        }

        
        foreach (string nimi in nimed)
        {
            if (!string.IsNullOrEmpty(nimi))
                Console.WriteLine(nimi.ToLower());
        }

        
        i = 0;
        do
        {
            if (nimed[i] == "Mati")
            {
                Console.WriteLine("Leidsin Mati");
                break;
            }
            Console.WriteLine($"Tere {nimed[i]}");
            i++;
        }
        while (i < nimed.Length);
    }

    static void Main()
    {
        string[] nimed = new string[6]; 
        Õpilastega_mängimine(nimed);
    }
}





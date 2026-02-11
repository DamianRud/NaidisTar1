using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;



//namespace NaidisTar1
//{
//public class EsimineOsaFunktsionid
//{
//    public static string juku(string nimi)
//    {
//            string pilet = "";

//            Console.WriteLine(nimi);

//            if (nimi.ToLower() == "juku")
//            {
//                Console.WriteLine("Kui vana sa oled?");

//                try
//                {
//                    int vanus = int.Parse(Console.ReadLine());

//                    if (vanus > 0 && vanus < 100)
//                    {
//                        if (vanus < 6)
//                            pilet = "Tasuta pilet";
//                        else if (vanus <= 14)
//                            pilet = "Lastepilet";
//                        else if (vanus <= 65)
//                            pilet = "Täispilet";
//                        else
//                            pilet = "Sooduspilet";
//                    }
//                    else
//                    {
//                        pilet = "Vanus peab olema positiivne ja väiksem kui 100!";
//                    }
//                }
//                catch (Exception)
//                {
//                    pilet = "Viga andmetega!";
//                }
//            }
//            else
//            {
//                pilet = "Sa ei ole Juku!";
//            }

//            return pilet

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Tere {i + 1}");
//}

//Console.WriteLine("While:");

//int j = 0;
//while (j < 10)
//{
//    Console.WriteLine($"Tere, {j + 1}");
//    j++;
//}


int j = 1;

while (j != 0)
{
}

int[] arvud = new int[5];


for (int i = 0; i < arvud.Length; i++)
{
    Console.WriteLine($"sisesta {i + 1}.arv:");

    try
    {
        arvud[i] = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
}


foreach (int arv in arvud)
{
    Console.WriteLine($"Sisesta arv: {arv}");
}


Console.WriteLine("For abil: esimene -> viimane");
for (int i = 0; i < arvud.Length; i++)
{
    Console.WriteLine($"sisestatud arv: {arvud[i]}");
}


Console.WriteLine("For abil: viimane -> esimene");
for (int i = arvud.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"sisestatud arv: {arvud[i]}");
}


Console.WriteLine("Kuhu: ");
int positsioon = int.Parse(Console.ReadLine());
Console.WriteLine("Miliseks");
int uus_arv = int.Parse(Console.ReadLine());
arvud[positsioon - 1] = uus_arv;
Console.WriteLine("Uuendatud massiiv");
for (int i=0; i<arvud.Length;i++ ) ;
{
    Console.WriteLine($"sisestatud arvud: {arvud[i]}");
}





using System;
using System.Collections.Generic;
using System.Text;

namespace NaidisTar1
{
    public class isik
    {
        public string Nimi;
        public int Vanus;
        public isik(string nimi,int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;

        }
        public isik() { }
        public void Tervita()
        {
            Console.WriteLine("Tere");
        }
    }
}

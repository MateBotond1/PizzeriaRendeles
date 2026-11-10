using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaRendeles
{
    public class Rendeles
    {
        public string VevoNev {  get; set; }
        public int PizzakSzama {  get; set; }
        public int TavolsagKm {  get; set; }
        public Rendeles(string sor)
        {
            string[] darabol = sor.Split(';');
            VevoNev = darabol[0];
            PizzakSzama = int.Parse(darabol[1]);
            TavolsagKm = int.Parse(darabol[2]);
        }
        public int FizetendoDij()
        {
            return PizzakSzama * 2500 + TavolsagKm * 300;
        }
        public override string ToString()
        {
            return $"{VevoNev}: {PizzakSzama} db pizza, {TavolsagKm} km - Fizetendő: {FizetendoDij} Ft";
        }
    }
        
}

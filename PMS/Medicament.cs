using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    internal class Medicament
    {

        public string Nume { get; set; }
        public int Pret { get; set; }
        public int Cantitate { get; set; }
        public Medicament(string nume, int pret, int cantitate)
        {
            Nume = nume;
            Pret = pret;
            Cantitate = cantitate;
        }


        public override string ToString()
        {
            return ($"Nume: {Nume}\nPret: {Pret}\nCantitate: {Cantitate}");
        }






    }
}

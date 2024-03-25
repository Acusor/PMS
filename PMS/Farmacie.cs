using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS
{
    internal class Farmacie
    {
        private List<Medicament> listaMedicamente;

        public Farmacie()
        {
            listaMedicamente = new List<Medicament>();
        }


        public void AdaugaMedicament()
        {
            Console.WriteLine("Introducere medicament");
            Console.Write("Nume medicament:");
            string nume = Console.ReadLine();
            Console.WriteLine("Pret medicament:");
            int pret = int.Parse(Console.ReadLine());
            Console.WriteLine("Numar cantitate:");
            int cantitate = int.Parse(Console.ReadLine());
            Medicament medicament = new Medicament(nume, pret, cantitate);
            listaMedicamente.Add(medicament);
            Console.WriteLine("Medicamentul a fost adaugat.");
        }


        public void AfiseazaMedicamente()
        {
            foreach(var medicament in listaMedicamente)
            {
                Console.WriteLine(medicament);
            }
        }

         public List<Medicament> CautaMedicamente(Func<Medicament, bool> criteriu)
        {
            List<Medicament> rezultat = new List<Medicament>();

            foreach (var medicament in listaMedicamente)
            {
                if (criteriu(medicament))
                {
                    rezultat.Add(medicament);
                }
            }

            return rezultat;
        }
    }
}

using PMS;
using System;

namespace proiect
{
    class Program
    {

        
        public static void Main(string[] args)
        {
            Farmacie farmacie = new Farmacie();
            while (true)
            {
                Console.WriteLine("**Aplicatie de gestiune a unei farmacii");
                Console.WriteLine("1.Citire date de la tastatura");
                Console.WriteLine("2.Afisarea datelor de la tastatura");
                Console.WriteLine("3.Cautarea dupa anumite criterii");
                string o = Console.ReadLine();
                switch (o)
                {
                    case "1":
                        Console.WriteLine("test");
                        farmacie.AdaugaMedicament();
                        
                        break;

                    case "2":
                        Console.WriteLine("test2");
                        farmacie.AfiseazaMedicamente();
                        break;

                    case "3":
                        Console.WriteLine("test3");
                        break;
                }
            }
        }









    }
}

    
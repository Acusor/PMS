using System;

namespace proiect
{
    class Program
    {

        class Sistem
        {

        }
        class Medicamente
        {
            public int id { get; set; }
            public string nume { get; set; }

            public string categorie { get; set; }
            public string descriere { get; set; }
            public double pret { get; set; }
            public int cantitate { get; set; }
            public string dataexpirare{get;set;}

           
        }
        class Furnizor
        {

        }
        class Inventar
        {

        }
        class BazaDeDate
        {

        }
        class Angajat
        {

        }
        class Client
        {

        }
        class Signin
        {

        }

        public static void Main(string[] args)
        {
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
                        CitireTastatura();
                        break;

                    case "2":
                        Console.WriteLine("test2");
                        break;

                    case "3":
                        Console.WriteLine("test3");
                        break;
                }
            }
        }







        static void CitireTastatura()
        {
            Console.WriteLine("Introduceti medicamentul:");
            string m;
            while((m=Console.ReadLine())!="atat")
            {
                string[] listamedicamente = m.Split(',');
                Medicamente medicament = new Medicamente
                {
                    id = int.Parse(listamedicamente[0]),
                    nume = listamedicamente[1],
                    descriere = listamedicamente[2],
                    pret = double.Parse(listamedicamente[3]),
                    cantitate = int.Parse(listamedicamente[4]),
                    dataexpirare =(listamedicamente[5])

                };
            }


            
           

        }

    }
}

    /*class Masinitza
    {
        public String model;
        public Masinitza(string model)
        {
            this.model = model;
        }

    }*/
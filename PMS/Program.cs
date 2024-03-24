using System;

namespace proiect
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Masinitza[] garaj = new Masinitza[3];
            Masinitza mas1 = new Masinitza("Mustang");
            Masinitza mas2 = new Masinitza("Dodge");
            Masinitza mas3 = new Masinitza("Camaro");
            garaj[0] = mas1;
            garaj[1] = mas2;
            garaj[2] = mas3;
           foreach(Masinitza mas in garaj)
            {
                Console.WriteLine(mas.model);
            }*/



            Masinitza[] garaj = { new Masinitza("Mustang"), new Masinitza("Dodge"),new Masinitza("Camaro") };
            foreach(Masinitza mas in garaj)
            {
                Console.WriteLine(mas.model);
            }

            Console.WriteLine("testez");
        }
        
    }

    class Masinitza
    {
        public String model;
        public Masinitza(string model)
        {
            this.model = model;
        }

    }
}
using System;

namespace Animales
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string opcion = "";
            Listadeanimales listadeanimales = new Listadeanimales();
            ListadeReptiles listadeReptiles = new ListadeReptiles();
            ListadeAves listadeAves = new ListadeAves();

            while (true)
            {
            Console.Clear();
            Console.WriteLine("Historial de animales Joya grande!");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Que Animales le Interesa conocer: ");
            Console.WriteLine("");
            Console.WriteLine("1- Mamiferos");
            Console.WriteLine("");
            Console.WriteLine("2- Reptiles");
            Console.WriteLine("");
            Console.WriteLine("3- Aves");
            Console.WriteLine("");
            Console.WriteLine("0- salir");
            opcion = Console.ReadLine();


            switch (opcion)
            {
                case "1": 
                    listadeanimales.listarMamifero();
                    break;
                case "2": 
                    listadeReptiles.listaReptiles();
                    break;
                case "3": 
                    listadeAves.ListadAves();
                    break;
                default:
                break;
            }
            if (opcion == "0") {
                break;
            }
        }
    }
    }
}

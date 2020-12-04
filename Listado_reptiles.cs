using System;
using System.Collections.Generic;

public class ListadeReptiles 
{
    public List<Reptiles> ListaReptiles { get; set; }

    public ListadeReptiles()
    {
        ListaReptiles = new List<Reptiles>();

        Reptiles r = new Reptiles("Rex", 16, "Macho", 5, false, true, "Cola Corta", "Cocodrilo");
        Reptiles r1 = new Reptiles("Mart", 20, "Hembra", 5, false, true, "Pecho blanco", "Cocodrilo");
        Reptiles r2= new Reptiles("Luz", 25, "Hembra", 5, false, true, "Nariz cortada", "Cocodrilo");
        Reptiles r3 = new Reptiles("Risas", 5, "Macho", 5, false, true, "Un solo Ojo", "Cocodrilo");
        Reptiles r4 = new Reptiles("Food", 17, "Macho", 5, false, true, "Alislado", "Cocodrilo");

        ListaReptiles.Add(r);
        ListaReptiles.Add(r1);
        ListaReptiles.Add(r2);
        ListaReptiles.Add(r3);
        ListaReptiles.Add(r4);
    }
    public void listaReptiles()
    {
       
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Reptiles en el Zoologico");
        Console.WriteLine("********************");
        Console.WriteLine("Datos de los animales ");
        Console.WriteLine("********************");
        Console.WriteLine("");

        foreach (var reptiles in ListaReptiles)
        {
            Console.WriteLine("Es un "+ reptiles.Especie + " Su nombre es " + reptiles.Nombre + " Tiene " + reptiles.Edad + " años " + " es " + reptiles.Genero + " tenemos en el parque " + reptiles.Cantidad + " de esta especie " + " Se distingue por que si pelaje que es " + reptiles.Piel);
            Console.WriteLine("");
            Console.WriteLine("*********************************************************************************************************************************************");
            Console.WriteLine("");
        }


        Console.ReadLine();
    }

}
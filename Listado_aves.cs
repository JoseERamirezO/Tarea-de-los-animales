using System;
using System.Collections.Generic;

public class ListadeAves
{
    public List<Aves> ListadeAve { get; set; }

    public ListadeAves()
    {
        ListadeAve = new List<Aves>();

        Aves a = new Aves ("Mango", 5, "Macho", 3, true, "Verde", "Guacamaya");
        Aves a1 = new Aves ("Manzana", 5, "Hembra", 3,  true, "Rojo", "Guacamaya");
        Aves a2 = new Aves ("Cielo", 5, "Hembra", 3,  true, "Azul", "Guacamaya");
        
        ListadeAve.Add(a);
        ListadeAve.Add(a1);
        ListadeAve.Add(a2);
    }
    public void ListadAves()
    {
       
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Aves en el Zoologico");
        Console.WriteLine("********************");
        Console.WriteLine("Datos de los animales");
        Console.WriteLine("********************");
        Console.WriteLine("");

        foreach (var aves in ListadeAve)
        {
            Console.WriteLine("Es un "+ aves.Especie + " Su nombre es " + aves.Nombre + " Tiene " + aves.Edad + " años " + " es " + aves.Genero + " tenemos en el parque " + aves.Cantidad + " de esta especie " + " Se distingue por que si pelaje que es " + aves.Plumaje);
            Console.WriteLine("");
            Console.WriteLine("*********************************************************************************************************************************************");
            Console.WriteLine("");
        }


        Console.ReadLine();
    }
}
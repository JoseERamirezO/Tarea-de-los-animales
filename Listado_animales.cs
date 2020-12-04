using System;
using System.Collections.Generic;

public class Listadeanimales
{
    public List<Mamiferos> ListadeMamiferos { get; set; }
    public Listadeanimales()
        {
            ListadeMamiferos = new List<Mamiferos>();

            Mamiferos m = new Mamiferos("chita", 12, "Hembra", 2, false, true, "Gris Poco pelo", "tigre");
            Mamiferos m1 = new Mamiferos("Ranger", 12, "Macho", 2, false, true, "Camuflajeado ", "tigre");
            ListadeMamiferos.Add(m);
            ListadeMamiferos.Add(m1);
        }
    public void listarMamifero() 
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Mamiferos en el Zoologico");
        Console.WriteLine("********************");
        Console.WriteLine("Datos de los animales");
        Console.WriteLine("********************");
        Console.WriteLine("");

        foreach (var mamiferos in ListadeMamiferos)
        {
            Console.WriteLine("Es un "+ mamiferos.Especie + " Su nombre es " + mamiferos.Nombre + " Tiene " + mamiferos.Edad + " años " + " es " + mamiferos.Genero + " tenemos en el parque " + mamiferos.Cantidad + " de esta especie " + " Se distingue por que si pelaje que es " + mamiferos.Pelaje);
            Console.WriteLine("");
            Console.WriteLine("*********************************************************************************************************************************************");
            Console.WriteLine("");       
        }

        Console.ReadLine();
    }

    


}
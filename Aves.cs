public class Aves : Descripcion
{
    public bool Crias{ get; set; }

    public string Plumaje { get; set; }
    public Aves (string nombre, int edad, string genero, int cantidad, bool crias, string plumaje, string especie)
    {
        Nombre = nombre;
        Edad = edad;
        Genero = genero;
        Cantidad = cantidad;
        Crias = crias;
        Plumaje = plumaje;
        Especie = especie;
    }
}

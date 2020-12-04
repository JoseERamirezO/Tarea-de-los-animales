public class Mamiferos : Descripcion
{
    public bool Crias{ get; set; }

    public bool Salvaje { get; set; }
    public string Pelaje { get; set; }
    public Mamiferos (string nombre, int edad, string genero, int cantidad, bool crias, bool salvaje, string pelaje, string especie)
    {
        Nombre = nombre;
        Edad = edad;
        Genero = genero;
        Cantidad = cantidad;
        Crias = crias;
        Salvaje = salvaje;
        Pelaje = pelaje;
        Especie = especie;
    }
}

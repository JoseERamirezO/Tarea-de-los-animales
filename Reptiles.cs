public class Reptiles : Descripcion
{
    public bool Crias{ get; set; }

    public bool Salvaje { get; set; }

    public string Piel { get; set; }

    public Reptiles (string nombre, int edad, string genero, int cantidad, bool crias, bool salvaje, string piel, string especie)
    {
        Nombre = nombre;
        Edad = edad;
        Genero = genero;
        Cantidad = cantidad;
        Crias = crias;
        Salvaje = salvaje;
        Piel = piel;
        Especie = especie;
    }
}

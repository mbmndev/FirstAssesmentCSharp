public abstract class Deportes
{
    public string nombre;
    public int jugadores;

    public Deportes(string nombre, int jugadores)
    {
        this.nombre = nombre;
        this.jugadores = jugadores;
    }

    public abstract string Descripcion();
}
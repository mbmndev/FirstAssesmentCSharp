using System;
Console.Clear();
Console.Write("Ingrese el nombre del deporte: (Fúltbol/Baloncesto/Béisbol)");
string? nombre = Console.ReadLine();

Console.Write("Ingrese el número de jugadores:");
int jugadores = 0;
Int32.TryParse(Console.ReadLine(), out jugadores);

Deportes? deporte = null;

switch (nombre!.ToLower())
{
    case "fútbol":
        Console.Write("Ingrese la posición del arquero:");
        string? posicionPortero = Console.ReadLine();
        deporte = new Futbol(nombre, jugadores, posicionPortero!);
        break;
    //Por si introduce el deporte sin tilde
    case "futbol":
        Console.Write("Ingrese la posición del arquero:");
        string? posicionPortero2 = Console.ReadLine();
        deporte = new Futbol(nombre, jugadores, posicionPortero2!);
        break;
    case "baloncesto":
        Console.Write("Ingrese la altura del aro:");
        double altura_aro = Convert.ToDouble(Console.ReadLine());
        deporte = new Baloncesto(nombre, jugadores, altura_aro);
        break;

    case "béisbol":
        Console.Write("Ingrese la descripción de la entrada extra:");
        string? entradaExtra = Console.ReadLine();
        deporte = new Beisbol(nombre, jugadores, entradaExtra!);
        break;
    //Por si introduce el deporte sin tilde
    case "beisbol":
        Console.Write("Ingrese la descripción de la entrada extra:");
        string? entradaExtra2 = Console.ReadLine();
        deporte = new Beisbol(nombre, jugadores, entradaExtra2!);
        break;

    default:
        Console.Write("El deporte ingresado no es válido.");
        return;
}

if (deporte!=null)
    Console.WriteLine(deporte.Descripcion());
Console.Write("Entre cualquier tecla");
Console.ReadKey();

using System;

public class Persona
{
    public Persona()
    {
    }

    private string nombre;
    private int edad;
    private string direccion;
    private string correoElectronico;

    public void ImprimirDatos()
    {

        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Dirección: {direccion}");
        Console.WriteLine($"Correo electrónico: {correoElectronico}");
    }

}

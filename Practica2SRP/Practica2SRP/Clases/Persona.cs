using System;

public class Persona
{
    public Persona(string N, int E, string D, string CE)
    {
        this.nombre = N;
        this.edad = E;
        this.direccion = D;
        this.correoElectronico = CE;
    }

    public string nombre;
    public int edad;
    public string direccion;
    public string correoElectronico;



    public void ImprimirDatos()
    {

        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Dirección: {direccion}");
        Console.WriteLine($"Correo electrónico: {correoElectronico}");
    }

}

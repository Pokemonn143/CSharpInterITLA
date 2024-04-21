// See https://aka.ms/new-console-template for more information
using Practica1.Punto1;
using Practica1.Punto2;
using Practica1.Punto3;

string Nombre;
int edad;
string ciudad;

Console.WriteLine("Ingrese el nombre:");

Nombre= Console.ReadLine();

Console.WriteLine("Ingrese la Edad:");

edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la Ciudad:");

ciudad = Console.ReadLine();

Console.WriteLine("\n");

Persona P = new Persona(Nombre, edad, ciudad);
P.MostrarDatos();
P.CalcularEdad();

//Estudiante  
Console.WriteLine("\n");

Console.WriteLine("==========Estudiante==========");

Console.WriteLine("\n");

string Carrera;
int Matricula;

    Console.WriteLine("Ingrese el nombre:");

    Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese la Edad:");

    edad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese la Ciudad:");

    ciudad = Console.ReadLine();

    Console.WriteLine("Ingrese la Carrera:");

    Carrera  = Console.ReadLine();

    Console.WriteLine("Ingrese la Matricula:");

    Matricula = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\n");

    Estudiante Student = new Estudiante(Carrera, Matricula, Nombre, edad, ciudad);

    Student.MostrarDatos();

//Figuras  
Console.WriteLine("\n");

Console.WriteLine("==========Figuras==========");

Console.WriteLine("\n");


    Rectangulo rectangulo = new Rectangulo { Base = 5, Altura = 10 };
    Circulo circulo = new Circulo { Radio = 3 };
    Triangulo triangulo = new Triangulo { Base = 4, Altura = 6 };


    Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
    Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
    Console.WriteLine("Área del triángulo: " + triangulo.CalcularArea());
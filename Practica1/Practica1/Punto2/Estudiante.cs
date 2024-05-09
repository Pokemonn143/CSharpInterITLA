using Practica1.Punto1;
using System;


namespace Practica1.Punto2
{
    public class Estudiante: Persona
    {
        public string  Carrera { get; set; }

        public int Matricula { get; set;}

        public Estudiante (string Carrera, int Matricula, string N, int E, string C)
        {
            base.Nombre = N;
            base.Edad = E;
            base.Ciudad = C;
            this.Carrera = Carrera;
            this.Matricula = Matricula;
        }

        public Estudiante ()
        {

        }

        public override void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + base.Nombre + "\n"
                              + "Edad: " + base.Edad + "\n"
                              + "Ciudad: " + base.Ciudad + "\n"
                              + "Carrera: " + Carrera + "\n"
                              + "Matricula: " + Matricula + "\n");
       

        }

        public override void CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad)) 
            {
                edad = edad - 1;
            }
            Console.WriteLine("La edad es: " + edad);
        }
    }



}

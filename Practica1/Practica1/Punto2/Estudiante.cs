using Practica1.Punto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + base.Nombre + "\n"
                              + "Edad: " + base.Edad + "\n"
                              + "Ciudad: " + base.Ciudad + "\n"
                              + "Carrera: " + Carrera + "\n"
                              + "Matricula: " + Matricula + "\n");
       

        }

    }



}

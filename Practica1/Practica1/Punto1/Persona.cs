using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Punto1
{
    public class Persona
    {
        //atributos
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Ciudad { get; set; }

        public Persona(string N, int E, string C)
        {

            this.Nombre = N;
            this.Edad = E;
            this.Ciudad = C;

        }

        public Persona() { }

        //Metodos

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre + "\n" + "Edad: " + Edad + "\n"+  "Ciudad:" + Ciudad+ "\n");

        }

        public void CalcularEdad()
        {
            Console.WriteLine("La persona tiene: " + Edad + " Años");

        }



    }

   

    }


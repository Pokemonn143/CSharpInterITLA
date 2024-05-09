

namespace Practica1.Punto1
{
    public abstract class Persona
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

        public abstract void MostrarDatos();

        //Console.WriteLine("Nombre: " + Nombre + "\n" + "Edad: " + Edad + "\n"+  "Ciudad:" + Ciudad+ "\n");



        public abstract void CalcularEdad(DateTime fecha);
        
            //Console.WriteLine("La persona tiene: " + Edad + " Años");

        



    }

   

    }


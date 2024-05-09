

namespace Practica1.Punto3
{
   
    public abstract class Figura
    {
        
        public abstract double CalcularArea();
    }

    //Rectángulo
    public class Rectangulo : Figura
    {
        
        public double Base { get; set; }
        public double Altura { get; set; }

        
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }

    //Círculo
    public class Circulo : Figura
    {
        
        public double Radio { get; set; }

        
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2); // ya que el radio del ciruclo es PI x el radio al cuadrado
        }
    }

    //Triángulo
    public class Triangulo : Figura
    {
        
        public double Base { get; set; }
        public double Altura { get; set; }

       
        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}

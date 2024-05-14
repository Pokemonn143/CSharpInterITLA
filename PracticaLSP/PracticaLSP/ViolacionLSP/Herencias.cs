using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLSP.ViolacionLSP
{
    public class Rectangulo : FiguraGeometrica
    {

        public int Area { get; set; }

        public  Rectangulo(int Base, int Altura)
            {
            base.Altura = Altura;
            base.Base = Base;
            }

        public Rectangulo()
        {
           
        }

        public int CalcularArea()
            {
            Area = Base * Altura;
            return Area;
            }
    }

    public class Cuadrado : FiguraGeometrica 
        {
        public int Area { get; set; }

        public Cuadrado()
        {
           
        }

        public Cuadrado(int Base, int Altura)
        {
            base.Altura = Altura;
            base.Base = Base;
        }

        public int CalcularArea()
        {
            Rectangulo Rec = new Rectangulo();
            Area = Base * Altura;
            return Rec.Area;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLSP.RefactorLSP
{
    public class Rectangulo2 : FiguraGeometrica2
    {

        

        public Rectangulo2(int Base, int Altura)
        {
            this.Altura = Altura;
            this.Base = Base;
        }

        public Rectangulo2()
        {

        }

        public int CalcularArea()
        {
            this.Area = Base * Altura;
            return Area;
        }
    }

    public class Cuadrado2 : FiguraGeometrica2
    {
       

        public Cuadrado2()
        {

        }

        public Cuadrado2(int Base, int Altura)
        {
            this.Altura = Altura;
            this.Base = Base;
        }

        public int CalcularArea()
        {
           
            this.Area = Base * Altura;
            return Area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6Lista10.SRC
{
    public class Retangulo : FormasGeometricas
    {
        public Retangulo (string _nome, double _base, double _altura) : base(_nome, _base, _altura)
        { }

        public override double Area()
        {
            double _area = Base * Altura;
            return _area;
        }

    }
}





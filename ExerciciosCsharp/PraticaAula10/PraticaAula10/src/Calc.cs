using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaAula10.src
{
    internal class Calc : IOperacoes
    {
        public double Dividir(double x, double y)
        {
            return x / y;
        }

        public double Multiplicar(double x, double y)
        {
            return x * y;
        }

        public double Somar(double x, double y)
        {
            return x + y;
        }

        public double Subtrair(double x, double y)
        {
            return x - y;
        }
    }
}

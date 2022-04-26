using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaAula10.src
{
    internal interface IOperacoes
    {
        double Somar(double x, double y);
        double Subtrair(double x, double y);
        double Multiplicar(double x, double y);
        double Dividir(double x, double y);
    }
}

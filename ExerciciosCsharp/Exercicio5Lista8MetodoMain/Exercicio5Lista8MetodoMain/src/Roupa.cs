using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5Lista8MetodoMain.src
{
    internal class Roupa
    {
        public string Tipo { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
       
        public Roupa()
        {

        }

        public Roupa(string _tipo, string _tamanho, string _cor, string _marca)
        {
            Tipo = _tipo;
            Tamanho = _tamanho;
            Cor = _cor;
            Marca = _marca;
        }

    }
}

using Impressora.Impressora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Modelos
{
    public class Hp : ImpressoraPadrao
    {
        public override void Imprimir()
        {
            Console.WriteLine("Preparando impressora hp");
            Console.WriteLine("Imprimindo...");
        }
    }
}

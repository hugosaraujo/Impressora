
using Impressora.Impressora;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Modelos
{
    public class Epson : ImpressoraPadrao
    {
        public override void Imprimir()
        {
            Console.WriteLine("Preparando impressora Epson");
            Console.WriteLine("Imprimindo...");
        }
    }
}

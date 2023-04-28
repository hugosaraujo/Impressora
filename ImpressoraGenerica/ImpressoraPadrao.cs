using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impressora.Impressora
{
    public class ImpressoraPadrao
    {
        public string Modelo { get; private set; }

        public ImpressoraPadrao(string modelo)
        {
            this.Modelo = modelo;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Preparando impresora {this.Modelo}");
            Console.WriteLine("Imprimindo...");
        }
        public void Scanear()
        {
            Console.WriteLine($"Preparando impresora {this.Modelo}");
            Console.WriteLine("Scaneando...");
        }
    }
}

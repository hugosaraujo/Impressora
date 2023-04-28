using Impressora.Impressora;


ImpressoraPadrao impressora = new ImpressoraPadrao("Epson");
ImpressoraPadrao impressora2 = new ImpressoraPadrao("Hp");

impressora2.Imprimir();
impressora.Imprimir();

Console.ReadLine();
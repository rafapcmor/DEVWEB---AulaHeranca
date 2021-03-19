using System;

namespace AulaHeranca
{
    class Program
    {
        static void Main(string[] args)
        {

            var cliente1 = new Cliente("Rafaela", 31, 'F', 3434345435, "crediario");
            var cliente2 = new Cliente("Mariana", 28, 'F', 438785600877, "crediario");

            var produto1 = new Produto("Caneta", 2.5);
            var produto2 = new Produto("Lapis", 2);
            var produto3 = new Produto("Borracha", 3.5);

            var vendedor1 = new Vendedor("Cintia", 21, 'F', 09832351655, 3500, 5);
            
            var venda1 = new Venda(produto1, cliente1, 10);
            var venda2 = new Venda(produto2, cliente1, 5);
            var venda3 = new Venda(produto3, cliente2, 2);

            vendedor1.ListaVendas.Add(venda1);
            vendedor1.ListaVendas.Add(venda2);
            vendedor1.ListaVendas.Add(venda3);

            Console.WriteLine(vendedor1.ToString());

            Console.ReadKey();
        }
    }

    
}

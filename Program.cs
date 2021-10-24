using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimple BlockChain = new ListaSimple();
            BlockChain.Mostrar();

            BlockChain.AddFinal(20);
            BlockChain.AddFinal(2);
            BlockChain.AddFinal(19);
            BlockChain.AddFinal(1);
            Console.WriteLine();
            BlockChain.Mostrar();

            BlockChain.OrdenarAscen();

            BlockChain.Mostrar();

            Console.Read();
        }
    }
}

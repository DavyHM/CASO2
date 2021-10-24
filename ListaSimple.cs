using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASO2
{
    class ListaSimple
    {
        public Nodo cabeza { get; set; }

        public void Mostrar()
        {
            Nodo actual = cabeza;
            if (actual==null)
            {
                Console.WriteLine("La lista no tiene elementos\n");
            }
            else
            {
                Console.WriteLine("Inicio de Lista:");
                while (actual != null)
                {
                    Console.WriteLine(actual.valor);
                    actual = actual.siguiente;
                }
                Console.WriteLine("Fin de Lista\n");
            }
        }

        public void AddFinal(int valor)
        {
            if (cabeza == null)
            {
                cabeza = new Nodo();
                cabeza.valor = valor;
                cabeza.siguiente = null;
                Console.WriteLine("Agregando elemento "+valor+" a nueva lista");
            }
            else
            {
                Console.WriteLine("Agregando elemento " + valor + " al final");
                Nodo actual = cabeza;
                Nodo nuevo = new Nodo();
                nuevo.valor = valor;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevo;
            }
        }

        public void OrdenarAscen()
        {
            Console.WriteLine("Ordenando lista en forma Ascendente...\n");
            int t = 1, cont = 1;
            Nodo actual = cabeza;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente;
                cont++;
            }
            int temp=0;
            do
            {
                actual = cabeza;
                Nodo sigui = actual.siguiente;
                while (actual.siguiente!=null)
                {
                    if (actual.valor>sigui.valor)
                    {
                        temp = actual.valor;
                        actual.valor = sigui.valor;
                        sigui.valor = temp;
                        actual = actual.siguiente;
                        sigui = sigui.siguiente;
                    }
                    else
                    {
                        actual = actual.siguiente;
                        sigui = sigui.siguiente;
                    }
                }
                t++;
            } while (t<=cont);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Nodo<T>
    {
        public T valor { get; set; }
        public Nodo<T> izquierdo { get; set; }
        public Nodo<T> derecho { get; set; }
    }

    public class ArbolBinario<T>
    {
        Nodo<T> Raiz;

        private void InOrden(Nodo<T> Aux, ref List<T> lista)
        {
            if (Aux != null)
            {
                InOrden(Aux.izquierdo, ref lista);
                lista.Add(Aux.valor);
                InOrden(Aux.derecho, ref lista);
            }
        }

        private void PreOrden(Nodo<T> Aux, ref List<T> lista)
        {
            if (Aux != null)
            {
                lista.Add(Aux.valor);
                PreOrden(Aux.izquierdo, ref lista);
                PreOrden(Aux.derecho, ref lista);
            }
        }

        private void PostOrden(Nodo<T> Aux, ref List<T> lista)
        {
            if (Aux != null)
            {
                PostOrden(Aux.izquierdo, ref lista);
                PostOrden(Aux.derecho, ref lista);
                lista.Add(Aux.valor);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaLab1
{
    public class Jugador
    {
        public string Club { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Posicion { get; set; }
        public double Salario { get; set; }
        public double Compensacion { get; set; }

    }

    public class Nodo
    {
        public Jugador jugador;
        public Nodo siguiente;
        public Nodo anterior;

        public Nodo(Jugador Valor, Nodo Siguiente, Nodo Anterior)
        {
            this.jugador = Valor;
            this.siguiente = Siguiente;
            this.anterior = Anterior;
        }

        public Nodo(Jugador valor) : this(valor, null, null) { }
    }

    public class ListaDoblementeEnlazada
    {
        Nodo inicio;

        public ListaDoblementeEnlazada()
        {
            this.inicio = null;
        }

        public bool ListaVacia()
        {
            return (inicio == null);
        }

        public Nodo UltimoElemento()
        {
            Nodo tempNodo;
            tempNodo = inicio;

            while (tempNodo.siguiente != null)
            {
                tempNodo = tempNodo.siguiente;
            }
            return tempNodo;
        }

        public void InsertarInicio(Jugador dtInfo)
        {
            Nodo nNuevo = new Nodo(dtInfo, null, null);

            if (!ListaVacia())
            {
                nNuevo.siguiente = inicio;
                inicio.anterior = nNuevo;
                inicio = nNuevo;
            }
            else
            {
                inicio = nNuevo;
            }
        }

        public void InsertarFinal(Jugador dtInfo)
        {
            Nodo nNuevo = new Nodo(dtInfo, null, null);

            Nodo tempNodo;

            if (!ListaVacia())
            {
                tempNodo = UltimoElemento();
                tempNodo.siguiente = nNuevo;
                nNuevo.anterior = tempNodo;
            }
            else
            {
                inicio = nNuevo;
            }
        }

        public void EliminarInicio()
        {
            if (!ListaVacia())
            {
                if (inicio.siguiente == null)
                {
                    inicio = null;
                }
                else
                {
                    inicio = inicio.siguiente;
                    inicio.anterior = null;
                }
            }
            else
            {
                //MessageBox.Show("La lista está vacía");
            }
        }

        public void EliminarFinal()
        {
            if (ListaVacia())
            {
                //MessageBox.Show("La lista está vacía");
            }
            else if (inicio.siguiente == null)
            {
                inicio = null;
            }
            else
            {
                Nodo NodoTemporal = inicio;
                while ((NodoTemporal.siguiente).siguiente != null)
                {
                    NodoTemporal = NodoTemporal.siguiente;
                }
                NodoTemporal.siguiente = null;
            }
        }
    }
}

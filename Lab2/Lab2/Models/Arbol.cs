using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class Arbol
    {
        public Pais valor { get; set; }

        public Arbol izquierdo { get; set; }

        public Arbol derecho { get; set; }

        public void Insertar(Pais pais) { }

        public void Eliminar(string nombre) { }

        public bool EsDegenerado() { return true; }

        public bool EsEquilibrado() { return true; }

        public string PreOrden() { return ""; }

        public string InOrden() { return ""; }

        public string PostOrden() { return ""; }
    }

    public class Pais
    {
        public string nombre { get; set; }

        public string Grupo { get; set; }
    }
}
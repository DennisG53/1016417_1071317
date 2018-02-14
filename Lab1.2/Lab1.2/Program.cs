using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    public delegate bool DelegateComparacion(Libro libro);
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Libro> lista = new LinkedList<Libro>();
            lista.AddLast(new Libro() { Id = 1, Nombre = "Don Quijote", Edicion = "Primera" });
            lista.AddLast(new Libro() { Id = 2, Nombre = "Baldor", Edicion = "Tercera" });
            lista.AddLast(new Libro() { Id = 3, Nombre = "Sr. Presidente", Edicion = "Segunda" });

            //Instancia del delegado
            DelegateComparacion delegado = new DelegateComparacion(EsPrimeraEdicion);
            Console.WriteLine(delegado(lista.First()));
            Console.WriteLine(delegado(lista.Last()));

            //Delegado tipo lambda
            //Este delegado toma a los que tienen la primera edicion
            DelegateComparacion delegado2 = x => x.Edicion == "Primera";

            //Delegado mezclado
            DelegateComparacion delegado3 = x =>
            {
                if (x.Edicion == "Primera")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };


            //Buscar el libro con nombre Baldor
            //Este es el delegado
            var result = lista.Where(libro => libro.Nombre == "Baldor").ToList();
            //La expresión de arriba equivale *-*-*
            var datos = lista.Where(variable => variable.Id == 1);

            //************ JUGADORES
            //var resultSalario = lista.Where(x => x.precio > 200 );

            //**********Eliminar JUGADORES
            //Libro paraEliminar = lista.Where(variable => variable.Id == 1).First();
            //lista.Remove(paraEliminar);

            var Bisiestos = lista.Where(x =>
            {
                if (x.Anio == 2017)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            Console.WriteLine("Result");
            foreach (var item in result)
            {
                Console.WriteLine(item.Id +", " +item.Nombre + ", " + item.Edicion);
            }


            Console.ReadKey();
        }

        static bool EsPrimeraEdicion(Libro libro)
        {
            if (libro.Edicion == "Primera")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //*-*-*
        //static Libro EsBaldor(Libro libro)
        //{
        //    if (libro.Nombre == "Baldor")
        //        {
        //        return libro;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }

    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Edicion { get; set; }
        public int Anio { get; set; }
        public int precio { get; set; }
    }
}

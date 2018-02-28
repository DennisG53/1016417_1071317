using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ArbolBinario<T>
    {
        public T valor { get; set; }
        public ArbolBinario<T> izquierdo { get; set; }
        public ArbolBinario<T> derecho { get; set; }
    }
}

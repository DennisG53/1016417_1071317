using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWALOROEDD.Models
{
    public class MyDbcontext : DbContext
    {
        //Esta es una colección de todos los usuarios en el contexto
        public DbSet<CuentaUsuario> cuentaUsuario { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EDDProyectoPreliminarHD.Models
{
    public class OurDbcontext : DbContext
    {
        public DbSet<CuentaUsuario> cuentaUsuario { get; set; }
    }
}
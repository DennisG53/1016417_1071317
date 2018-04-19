using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proyecto_MVC.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<CuentaUsuario> cuentaUsuario { get; set; }

        public DbSet<MediaVisual> mediaVisual { get; set; }
    }
}
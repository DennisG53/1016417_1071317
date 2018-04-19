using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EDDProyectoPreliminarHD.Models;

namespace EDDProyectoPreliminarHD.Controllers
{
    public class CuentaUsuarioController : Controller
    {
        // GET: CuentaUsuario
        public ActionResult Index()
        {
            //List<CuentaUsuario> listaUsuarios = new List<CuentaUsuario>();

            return View();
        }
    }
}
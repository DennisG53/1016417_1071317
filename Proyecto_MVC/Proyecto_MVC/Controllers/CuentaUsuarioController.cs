using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_MVC.Models;

namespace Proyecto_MVC.Controllers
{
    public class CuentaUsuarioController : Controller
    {
        // GET: CuentaUsuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegistrarUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarUser(CuentaUsuario cuenta)
        {
            if (ModelState.IsValid)
            {
                //Agregar a la lista

                //Waiting

                ModelState.Clear();
                ViewBag.Message = cuenta.Username + " registrado correctamente.";
            }
            return View();
        }

        //Login
        public ActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Login(CuentaUsuario user)
        //{

        //}

    }
}
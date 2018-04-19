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
        List<CuentaUsuario> ListaUsuariosGuardados;

        public CuentaUsuarioController()
        {
            ListaUsuariosGuardados = new List<CuentaUsuario>();
        }
        // GET: CuentaUsuario
        public ActionResult Index()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return View(db.cuentaUsuario.ToList());
            }
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
                using (MyDbContext db = new MyDbContext())
                {
                    db.cuentaUsuario.Add(cuenta);
                    db.SaveChanges();
                    ListaUsuariosGuardados.Add(cuenta);
                }
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

        [HttpPost]
        public ActionResult Login(CuentaUsuario user)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var ausrr = db.cuentaUsuario.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
                if (ausrr != null)
                {
                    Session["UserId"] = ausrr.UserID.ToString();
                    Session["Username"] = ausrr.Username.ToString();
                    return RedirectToAction("Logeado");
                }
                else
                {
                    ModelState.AddModelError("", "Nombre de Usuario o Contraseña incorrecta.");
                }
            }
            return View();
        }

        public ActionResult Logeado()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
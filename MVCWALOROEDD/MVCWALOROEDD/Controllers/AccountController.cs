using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using MVCWALOROEDD.Models;
using Newtonsoft.Json;

namespace MVCWALOROEDD.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using (MyDbcontext db = new MyDbcontext())
            {
                System.IO.File.WriteAllText(@"C:\usuario.json", "[" + Session["ARCHIVOJSON"].ToString() + "]");

                return View(db.cuentaUsuario.ToList());

            }

        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(CuentaUsuario account)
        {
            if (ModelState.IsValid)
            {
                using (MyDbcontext db = new MyDbcontext())
                {
                    db.cuentaUsuario.Add(account);
                    db.SaveChanges();
                    if (Session["ARCHIVOJSON"].ToString() == string.Empty)
                    {
                        Session["ARCHIVOJSON"] = JsonConvert.SerializeObject(db.cuentaUsuario);
                    }
                    else
                    {
                        Session["ARCHIVOJSON"] = Session["ARCHIVOJSON"].ToString() + "," + JsonConvert.SerializeObject(db.cuentaUsuario);
                    }
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " successfully registered.";
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
            using (MyDbcontext db = new MyDbcontext())
            {
                var usr = db.cuentaUsuario.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
                if (usr != null && usr.Username != "admin")
                {
                    //Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.Username.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else if (usr.Username == "admin")
                {
                    //Session["UserID"] = usr.UserID.ToString();
                    Session["Username"] = usr.Username.ToString();
                    return RedirectToAction("Admin");
                }
                else
                {
                    ModelState.AddModelError("", "UserName or Password is wrong.");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["Username"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Admin()
        {
            if (Session["Username"] != null)
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
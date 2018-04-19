using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_MVC.Models;

namespace Proyecto_MVC.Controllers
{
    public class MediaVisualController : Controller
    {
        List<MediaVisual> ListaMedia;
        MediaVisualController()
        {
            ListaMedia = new List<MediaVisual>();
        }

        // GET: MediaVisual
        public ActionResult Index()
        {
            using (MyDbContext db = new MyDbContext())
            {
                return View(db.mediaVisual.ToList());
            }
        }

        public ActionResult AgregarMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgregarMedia(MediaVisual pelishow)
        {
            if (ModelState.IsValid)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    db.mediaVisual.Add(pelishow);
                    db.SaveChanges();
                    ListaMedia.Add(pelishow);
                }
                ModelState.Clear();
                ViewBag.Message = pelishow.Nombre + " agregado correctamente.";
            }
            return View();
        }
    }
}
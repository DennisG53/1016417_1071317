using ClassLibrary1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //IMPORTANTE

        //public ActionResult SubirArbol()
        //{
        //    return View();
        //}

        ////Logica para evaluar el archivo
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Upload(HttpPostedFileBase upload)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        if (upload != null && upload.ContentLength > 0)
        //        {

        //            if (upload.FileName.EndsWith(".json"))
        //            {
        //                Stream stream = upload.InputStream;
        //                new StreamReader(stream);
                        
        //                //TempData["Intento"] = System.IO.File.ReadAllText(upload.FileName);

        //                //var arbol = JsonConvert.DeserializeObject<ArbolBinario<string>>(contenido);
        //                //Stream stream = upload.InputStream;
        //                //using (CsvReader csvReader =
        //                //    new CsvReader(new StreamReader(stream), true))
        //                //{
        //                //    csvTable.Load(csvReader);
        //                //}
        //                //return View(csvTable);
        //            }
        //            else
        //            {
        //                ModelState.AddModelError("File", "This file format is not supported");
        //                return View();
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("File", "Please Upload Your file");
        //        }
        //    }
        //    return View();
        //}



    }
}
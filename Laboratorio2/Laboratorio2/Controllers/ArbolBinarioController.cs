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
    public class ArbolBinarioController : Controller
    {
        // GET: ArbolBinario
        public ActionResult Index()
        {
            return View();
        }

        // GET: ArbolBinario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArbolBinario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArbolBinario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ArbolBinario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArbolBinario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ArbolBinario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArbolBinario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //////////////////////////////OHHHHHHHHHHHHHHHH/////////////////////////////////

        public ActionResult SubirArbol()
        {
            var path = @"C:\Users\denni\Downloads\URL\Estructura de Datos I\Laboratorio\Laboratorio 2\datacadenas.json";
            var contenido = System.IO.File.ReadAllText(path);
            var arbol = JsonConvert.DeserializeObject<ArbolBinario<string>>(contenido);

            var cadena = JsonConvert.SerializeObject(arbol);
            TempData["Arbol"] = cadena;

            return View();
        }



        //Logica para evaluar el archivo
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult SubirArbol(HttpPostedFileBase upload)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        if (upload != null && upload.ContentLength > 0)
        //        {

        //            if (upload.FileName.EndsWith(".json"))
        //            {
        //                Stream stream = upload.InputStream;
        //                new StreamReader(stream);


        //                var contenido = System.IO.File.ReadAllText(upload.FileName);

        //                var arbol = JsonConvert.DeserializeObject<ArbolBinario<string>>(contenido);

        //                var cadena = JsonConvert.SerializeObject(arbol);

        //                TempData["Arbol"] = cadena;

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

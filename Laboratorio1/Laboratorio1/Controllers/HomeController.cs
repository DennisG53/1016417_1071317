using LumenWorks.Framework.IO.Csv;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibreriaLab1;

namespace Laboratorio1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {

                if (upload != null && upload.ContentLength > 0)
                {

                    if (upload.FileName.EndsWith(".csv"))
                    {
                        Stream stream = upload.InputStream;
                        DataTable csvTable = new DataTable();
                        using (CsvReader csvReader = new CsvReader(new StreamReader(stream), true))
                        {
                            csvTable.Load(csvReader);
                        }

                        ListaDoblementeEnlazada Lista = new ListaDoblementeEnlazada();

                        foreach (DataRow row in csvTable.Rows.Cast<DataRow>().Skip(1))
                        {
                            Jugador nuevoJugador = new Jugador();
                            nuevoJugador.Club = row[csvTable.Columns[0]].ToString();
                            nuevoJugador.Apellido = row[csvTable.Columns[1]].ToString();
                            nuevoJugador.Nombre = row[csvTable.Columns[2]].ToString();
                            nuevoJugador.Posicion = row[csvTable.Columns[3]].ToString();
                            nuevoJugador.Salario = double.Parse(row[csvTable.Columns[4]].ToString());
                            nuevoJugador.Compensacion = double.Parse(row[csvTable.Columns[5]].ToString());
                            Lista.InsertarFinal(nuevoJugador);
                        }
                        return View(csvTable);
                    }
                    else
                    {
                        ModelState.AddModelError("File", "This file format is not supported");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("File", "Please Upload Your file");
                }
            }
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
    }
}